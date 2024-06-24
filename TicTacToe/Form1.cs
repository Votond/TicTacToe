namespace TicTacToe
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void WriteLogsMessage(string message)
        {
            LogsTextBox.Text += message;
        }

        public void UpdateGameView(GameManager.Game.PlayingFieldInfo.CellState[] cells)
        {
            int i = 0;
            foreach (var cell in cells)
            {
                if (cell != GameManager.Game.PlayingFieldInfo.CellState.None)
                {
                    ((PictureBox) GameViewPanel.Controls[i]).Visible = true;
                    ((PictureBox) GameViewPanel.Controls[i]).Image = (cell == GameManager.Game.PlayingFieldInfo.CellState.Cross) ? Properties.Resources.cross : Properties.Resources.circle;
                }
                else
                {
                    ((PictureBox) GameViewPanel.Controls[i]).Visible = false;
                }

                i++;
            }
        }

        private void EnableBotButton_Click(object sender, EventArgs e)
        {
            var token = TokenTextBox.Text;

            if (token == null || token.Trim() == "")
            {
                MessageBox.Show("Введите токен бота", "Telegram Bot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            new Thread(() =>
            {
                TelegramBot.Instance.Init(token);
            }).Start();

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

        private void Cell_Click(object sender, EventArgs e)
        {
            ((PictureBox) sender).Image = (((PictureBox)sender).Image == Properties.Resources.cross) ? Properties.Resources.circle : Properties.Resources.cross;
        }
    }
}
