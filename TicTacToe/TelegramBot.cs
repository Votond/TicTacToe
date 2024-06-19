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

        public static TelegramBot Instance {get; private set;} = new TelegramBot();

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

            await Logs.Info("Бот запущен");
        }

        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message == null)
                return;

            if (update.Message.Text == null)
                return;

            await Logs.Info("Бот принял апдейт");

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

                NewGame(chatId, split[1]);
            }
            else
                IncorrectInput(chatId);

            await Logs.Info("Бот обработал апдейт");
        }

        private async Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            await Logs.Error(ErrorMessage);
        }

        public async Task Shutdown()
        { 
            if (!IsLaunched) 
                return;

            _cts.Cancel();
            IsLaunched = false;
            await Logs.Info("Бот отключен");
        }

        public async void SendMessage(ChatId chatId, string message) => await _botClient.SendTextMessageAsync
        (
            chatId: chatId,
            text: message,
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

        private void IncorrectInput(ChatId chatId) => SendMessage(chatId, "❌ Некорректный ввод");

        private void Start(ChatId chatId) => SendMessage(chatId,
            $"Бот для игры в \"крестики-нолики\"\nВаш ID: {chatId}\n\nКоманды:\n/newGame UserId - начать новую игру");

        private void NewGame(ChatId chatId, string userId)
        {
            if (new Random().Next(0, 100) > 50)
                GameManager.Instance.StartNewGame(chatId.ToString(), userId);
            else
                GameManager.Instance.StartNewGame(userId, chatId.ToString());
        }
    }
}