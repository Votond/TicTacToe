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

        private static readonly TelegramBot instance = new TelegramBot();
        public static TelegramBot GetInstance() => instance;

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
        }

        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message == null)
                return;

            if (update.Message.Text == null)
                return;

            var message = update.Message;
            var messageText = update.Message.Text;
            var chatId = message.Chat.Id;

            switch (messageText)
            {


                default:
                    IncorrectInput(chatId);
                    break;
            }
        }

        Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }

        public void Shutdown() { if (IsLaunched) _cts.Cancel(); }

        private async void IncorrectInput(ChatId chatId)
            => await _botClient.SendTextMessageAsync
            (
                chatId: chatId,
                text: "❌ Некорректный ввод",
                cancellationToken: _cts.Token
            );
    }
}