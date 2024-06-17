namespace TicTacToe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnableBotButton_Click(object sender, EventArgs e)
        {
            var token = TokenTextBox.Text;

            if (token == null || token.Trim() == "")
            {
                MessageBox.Show("Введите токен бота", "Telegram Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TelegramBot.GetInstance().Init(token);

            BotStatusTextLabel.Text = "Включён";
            BotStatusTextLabel.ForeColor = TelegramBot.StatusColors.ON;
        }

        private void DisableBotButton_Click(object sender, EventArgs e)
        {
            if (!TelegramBot.GetInstance().IsLaunched)
            {
                MessageBox.Show("Бот выключен", "Telegram Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TelegramBot.GetInstance().Shutdown();

            BotStatusTextLabel.Text = "Отключён";
            BotStatusTextLabel.ForeColor = TelegramBot.StatusColors.OFF;
        }
    }
}
