using System.Drawing.Imaging;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace TicTacToe
{
    internal class TelegramBot
    {
        internal class StatusColors
        {
            public static System.Drawing.Color OFF = System.Drawing.Color.Red;
            public static System.Drawing.Color ON = System.Drawing.Color.Green;
        }

        private static TelegramBot? _instance;
        public static TelegramBot Instance {
            get {
                if (_instance == null)
                    _instance = new TelegramBot();

                return _instance;
            }
        }

        public bool IsLaunched { private set; get; }
        private string _token;
        private TelegramBotClient _botClient;
        private User _botUser;
        private CancellationTokenSource _cts;

        public async void Init(string token)
        {
            _token = token;
            _botClient = new TelegramBotClient(_token);
            _cts = new();

            ReceiverOptions receiverOptions = new() { AllowedUpdates = Array.Empty<UpdateType>() };

            _botClient.StartReceiving(
                updateHandler: HandleUpdateAsync,
                pollingErrorHandler: HandlePollingErrorAsync,
                receiverOptions: receiverOptions,
                cancellationToken: _cts.Token
            );

            _botUser = await _botClient.GetMeAsync(_cts.Token);
            IsLaunched = true;

            Logs.Info("Бот запущен");
        }

        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message == null)
                return;

            if (update.Message.Text == null)
                return;

            Logs.Info("Бот принял апдейт");

            var message = update.Message;
            string messageText = update.Message.Text;
            var chatId = message.Chat.Id;

            if (messageText == "/start")
                Start(chatId);
            else if (messageText.Contains("/newGame"))
            {
                var split = messageText.Split(' ');

                if (split.Length < 2)
                {
                    IncorrectInput(chatId);
                    return;
                }

                if (GameManager.Instance.GetGameByPlayerId(chatId.ToString()) != null)
                {
                    FinishPlaying(chatId);
                    return;
                }

                if (GameManager.Instance.GetGameByPlayerId(split[1]) != null)
                {
                    FinishPlayingOther(chatId);
                    return;
                }

                GameManager.Instance.StartNewGame(chatId.ToString(), split[1]);
            }
            else if (messageText.Contains("/turn"))
            {
                var split = messageText.Split(' ');

                if (split.Length < 2)
                {
                    IncorrectInput(chatId);
                    return;
                }

                var game = GameManager.Instance.GetGameByPlayerId(chatId.ToString());

                if (game == null)
                {
                    NoGame(chatId);
                    return;
                }

                var convertedCell = Convert.ToInt32(split[1]);

                if (convertedCell > 9 || convertedCell < 1)
                {
                    IncorrectInput(chatId);
                    return;
                }

                var turnStatus = game.MakeTurn(chatId.ToString(), Convert.ToInt32(split[1]));

                if (turnStatus == GameManager.Game.TurnStatus.NoTurn)
                {
                    NoTurn(chatId);
                    return;
                }

                if (turnStatus == GameManager.Game.TurnStatus.NoAbilityToTurn)
                {
                    NoAbilityToTurn(chatId);
                    return;
                }

                string player2;

                if (game.PlayerOne.UserId == chatId.ToString())
                    player2 = game.PlayerTwo.UserId;
                else
                    player2 = game.PlayerOne.UserId;

                SuccessfullyTurned(chatId);
                SuccessfullyTurnedOther(new ChatId(Convert.ToInt64(player2)), chatId.ToString());

                SendImage(chatId, await GameDrawer.Instance.Draw(game));
                SendImage(player2, await GameDrawer.Instance.Draw(game));
            }
            else
                IncorrectInput(chatId);

            Logs.Info("Бот обработал апдейт");
        }

        private async Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Logs.Error(ErrorMessage);
            throw exception;
        }

        public async void Shutdown()
        { 
            if (!IsLaunched) 
                return;

            _cts.Cancel();
            IsLaunched = false;
            Logs.Info("Бот отключен");
        }

        public async void SendMessage(ChatId chatId, string message) => await _botClient.SendTextMessageAsync
        (
            chatId: chatId,
            text: message,
            parseMode: ParseMode.MarkdownV2,
            cancellationToken: _cts.Token
        );

        public async void SendImage(ChatId chatId, Image image)
        {
            var stream = new MemoryStream();
            image.Save(stream, ImageFormat.Jpeg);
            stream.Position = 0;

            await _botClient.SendPhotoAsync(
                chatId: chatId,
                photo: InputFile.FromStream(stream),
                cancellationToken: _cts.Token);
        }

        private void Start(ChatId chatId) => SendMessage(chatId, 
            $"✨ *Бот для игры в _крестики нолики_*\n🆔 Ваш ID: `{chatId}`\n\nℹ Команды:\n`/newGame UserId` начать новую игру");
        private void IncorrectInput(ChatId chatId) => SendMessage(chatId, "❌ Некорректный ввод");
        private void NoGame(ChatId chatId) => SendMessage(chatId, "❌ У вас нет идущей игры");
        private void NoTurn(ChatId chatId) => SendMessage(chatId, "❌ Сейчас не ваш ход");
        private void NoAbilityToTurn(ChatId chatId) => SendMessage(chatId, "❌ Вы не можете так сходить");
        private void SuccessfullyTurned(ChatId chatId) => SendMessage(chatId, "✅ Вы совершили ход");
        private void SuccessfullyTurnedOther(ChatId chatId, string userId) => SendMessage(chatId, $"✅ [`{userId}`] совершил ход");
        private void FinishPlaying(ChatId chatId) => SendMessage(chatId, "❌ Доиграйте текущую игру");
        private void FinishPlayingOther(ChatId chatId) => SendMessage(chatId, "❌ Игрок должен доиграть свою игру");
        public void Win(ChatId chatId, string winnerId) => SendMessage(chatId, $"🥳 [`{winnerId}`] победил!");
    }
}