namespace TicTacToe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void WriteLogsMessage(string message)
        {
            LogsTextBox.Text += message;
        }

        public void UpdateGameView(Image image)
        {
            GamePictureBox.Image = image;
        }

        private void EnableBotButton_Click(object sender, EventArgs e)
        {
            var token = TokenTextBox.Text;

            if (token == null || token.Trim() == "")
            {
                MessageBox.Show("Введите токен бота", "Telegram Bot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TelegramBot.Instance.Init(token);

            BotStatusTextLabel.Text = "Включён";
            BotStatusTextLabel.ForeColor = TelegramBot.StatusColors.ON;
        }

        private void DisableBotButton_Click(object sender, EventArgs e)
        {
            if (!TelegramBot.Instance.IsLaunched)
            {
                MessageBox.Show("Бот уже отключен", "Telegram Bot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TelegramBot.Instance.Shutdown();

            BotStatusTextLabel.Text = "Отключён";
            BotStatusTextLabel.ForeColor = TelegramBot.StatusColors.OFF;
        }

        private void ClearLogsButton_Click(object sender, EventArgs e)
        {
            LogsTextBox.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
