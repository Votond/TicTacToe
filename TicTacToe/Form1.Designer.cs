namespace TicTacToe
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl = new TabControl();
            AdminPage = new TabPage();
            TableLayoutPanel = new TableLayoutPanel();
            GameBox = new GroupBox();
            GameViewPanel = new TableLayoutPanel();
            Cell9 = new PictureBox();
            Cell8 = new PictureBox();
            Cell7 = new PictureBox();
            Cell6 = new PictureBox();
            Cell5 = new PictureBox();
            Cell4 = new PictureBox();
            Cell3 = new PictureBox();
            Cell2 = new PictureBox();
            Cell1 = new PictureBox();
            BotBox = new GroupBox();
            ClearLogsButton = new Button();
            LogsLabel = new Label();
            LogsTextBox = new RichTextBox();
            DisableBotButton = new Button();
            EnableBotButton = new Button();
            TokenTextBox = new TextBox();
            BotStatusTextLabel = new Label();
            BotStatusLabel = new Label();
            GamePage = new TabPage();
            BorderPanel1 = new Panel();
            BorderPanel2 = new Panel();
            BorderPanel3 = new Panel();
            BorderPanel4 = new Panel();
            TabControl.SuspendLayout();
            AdminPage.SuspendLayout();
            TableLayoutPanel.SuspendLayout();
            GameBox.SuspendLayout();
            GameViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Cell9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cell8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cell7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cell6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cell5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cell4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cell3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cell2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cell1).BeginInit();
            BotBox.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(AdminPage);
            TabControl.Controls.Add(GamePage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(484, 461);
            TabControl.TabIndex = 0;
            // 
            // AdminPage
            // 
            AdminPage.Controls.Add(TableLayoutPanel);
            AdminPage.Location = new Point(4, 24);
            AdminPage.Name = "AdminPage";
            AdminPage.Padding = new Padding(3);
            AdminPage.Size = new Size(476, 433);
            AdminPage.TabIndex = 0;
            AdminPage.Text = "Админ панель";
            AdminPage.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Controls.Add(GameBox, 1, 0);
            TableLayoutPanel.Controls.Add(BotBox, 0, 0);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(3, 3);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 1;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Size = new Size(470, 427);
            TableLayoutPanel.TabIndex = 0;
            // 
            // GameBox
            // 
            GameBox.Controls.Add(BorderPanel4);
            GameBox.Controls.Add(BorderPanel3);
            GameBox.Controls.Add(BorderPanel2);
            GameBox.Controls.Add(BorderPanel1);
            GameBox.Controls.Add(GameViewPanel);
            GameBox.Dock = DockStyle.Fill;
            GameBox.Location = new Point(238, 3);
            GameBox.Name = "GameBox";
            GameBox.Size = new Size(229, 421);
            GameBox.TabIndex = 1;
            GameBox.TabStop = false;
            GameBox.Text = "Игра";
            // 
            // GameViewPanel
            // 
            GameViewPanel.ColumnCount = 3;
            GameViewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GameViewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            GameViewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            GameViewPanel.Controls.Add(Cell9, 2, 2);
            GameViewPanel.Controls.Add(Cell8, 1, 2);
            GameViewPanel.Controls.Add(Cell7, 0, 2);
            GameViewPanel.Controls.Add(Cell6, 2, 1);
            GameViewPanel.Controls.Add(Cell5, 1, 1);
            GameViewPanel.Controls.Add(Cell4, 0, 1);
            GameViewPanel.Controls.Add(Cell3, 2, 0);
            GameViewPanel.Controls.Add(Cell2, 1, 0);
            GameViewPanel.Controls.Add(Cell1, 0, 0);
            GameViewPanel.Location = new Point(14, 110);
            GameViewPanel.Name = "GameViewPanel";
            GameViewPanel.RowCount = 3;
            GameViewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameViewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameViewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameViewPanel.Size = new Size(200, 200);
            GameViewPanel.TabIndex = 0;
            // 
            // Cell9
            // 
            Cell9.Dock = DockStyle.Fill;
            Cell9.Image = Properties.Resources.cross;
            Cell9.Location = new Point(135, 135);
            Cell9.Name = "Cell9";
            Cell9.Size = new Size(62, 62);
            Cell9.SizeMode = PictureBoxSizeMode.StretchImage;
            Cell9.TabIndex = 8;
            Cell9.TabStop = false;
            Cell9.Visible = false;
            Cell9.Click += Cell_Click;
            // 
            // Cell8
            // 
            Cell8.Dock = DockStyle.Fill;
            Cell8.Image = Properties.Resources.cross;
            Cell8.Location = new Point(69, 135);
            Cell8.Name = "Cell8";
            Cell8.Size = new Size(60, 62);
            Cell8.SizeMode = PictureBoxSizeMode.StretchImage;
            Cell8.TabIndex = 7;
            Cell8.TabStop = false;
            Cell8.Visible = false;
            Cell8.Click += Cell_Click;
            // 
            // Cell7
            // 
            Cell7.Dock = DockStyle.Fill;
            Cell7.Image = Properties.Resources.cross;
            Cell7.Location = new Point(3, 135);
            Cell7.Name = "Cell7";
            Cell7.Size = new Size(60, 62);
            Cell7.SizeMode = PictureBoxSizeMode.StretchImage;
            Cell7.TabIndex = 6;
            Cell7.TabStop = false;
            Cell7.Visible = false;
            Cell7.Click += Cell_Click;
            // 
            // Cell6
            // 
            Cell6.Dock = DockStyle.Fill;
            Cell6.Image = Properties.Resources.cross;
            Cell6.Location = new Point(135, 69);
            Cell6.Name = "Cell6";
            Cell6.Size = new Size(62, 60);
            Cell6.SizeMode = PictureBoxSizeMode.StretchImage;
            Cell6.TabIndex = 5;
            Cell6.TabStop = false;
            Cell6.Visible = false;
            Cell6.Click += Cell_Click;
            // 
            // Cell5
            // 
            Cell5.Dock = DockStyle.Fill;
            Cell5.Image = Properties.Resources.cross;
            Cell5.Location = new Point(69, 69);
            Cell5.Name = "Cell5";
            Cell5.Size = new Size(60, 60);
            Cell5.SizeMode = PictureBoxSizeMode.StretchImage;
            Cell5.TabIndex = 4;
            Cell5.TabStop = false;
            Cell5.Visible = false;
            Cell5.Click += Cell_Click;
            // 
            // Cell4
            // 
            Cell4.Dock = DockStyle.Fill;
            Cell4.Image = Properties.Resources.cross;
            Cell4.Location = new Point(3, 69);
            Cell4.Name = "Cell4";
            Cell4.Size = new Size(60, 60);
            Cell4.SizeMode = PictureBoxSizeMode.StretchImage;
            Cell4.TabIndex = 3;
            Cell4.TabStop = false;
            Cell4.Visible = false;
            Cell4.Click += Cell_Click;
            // 
            // Cell3
            // 
            Cell3.Dock = DockStyle.Fill;
            Cell3.Image = Properties.Resources.cross;
            Cell3.Location = new Point(135, 3);
            Cell3.Name = "Cell3";
            Cell3.Size = new Size(62, 60);
            Cell3.SizeMode = PictureBoxSizeMode.StretchImage;
            Cell3.TabIndex = 2;
            Cell3.TabStop = false;
            Cell3.Visible = false;
            Cell3.Click += Cell_Click;
            // 
            // Cell2
            // 
            Cell2.Dock = DockStyle.Fill;
            Cell2.Image = Properties.Resources.cross;
            Cell2.Location = new Point(69, 3);
            Cell2.Name = "Cell2";
            Cell2.Size = new Size(60, 60);
            Cell2.SizeMode = PictureBoxSizeMode.StretchImage;
            Cell2.TabIndex = 1;
            Cell2.TabStop = false;
            Cell2.Visible = false;
            Cell2.Click += Cell_Click;
            // 
            // Cell1
            // 
            Cell1.Dock = DockStyle.Fill;
            Cell1.Image = Properties.Resources.cross;
            Cell1.Location = new Point(3, 3);
            Cell1.Name = "Cell1";
            Cell1.Size = new Size(60, 60);
            Cell1.SizeMode = PictureBoxSizeMode.StretchImage;
            Cell1.TabIndex = 0;
            Cell1.TabStop = false;
            Cell1.Visible = false;
            Cell1.Click += Cell_Click;
            // 
            // BotBox
            // 
            BotBox.Controls.Add(ClearLogsButton);
            BotBox.Controls.Add(LogsLabel);
            BotBox.Controls.Add(LogsTextBox);
            BotBox.Controls.Add(DisableBotButton);
            BotBox.Controls.Add(EnableBotButton);
            BotBox.Controls.Add(TokenTextBox);
            BotBox.Controls.Add(BotStatusTextLabel);
            BotBox.Controls.Add(BotStatusLabel);
            BotBox.Dock = DockStyle.Fill;
            BotBox.Location = new Point(3, 3);
            BotBox.Name = "BotBox";
            BotBox.Size = new Size(229, 421);
            BotBox.TabIndex = 0;
            BotBox.TabStop = false;
            BotBox.Text = "Бот";
            // 
            // ClearLogsButton
            // 
            ClearLogsButton.Location = new Point(47, 343);
            ClearLogsButton.Name = "ClearLogsButton";
            ClearLogsButton.Size = new Size(135, 24);
            ClearLogsButton.TabIndex = 7;
            ClearLogsButton.Text = "Очистить логи";
            ClearLogsButton.UseVisualStyleBackColor = true;
            ClearLogsButton.Click += ClearLogsButton_Click;
            // 
            // LogsLabel
            // 
            LogsLabel.AutoSize = true;
            LogsLabel.Location = new Point(97, 117);
            LogsLabel.Name = "LogsLabel";
            LogsLabel.Size = new Size(34, 15);
            LogsLabel.TabIndex = 6;
            LogsLabel.Text = "Логи";
            // 
            // LogsTextBox
            // 
            LogsTextBox.Location = new Point(6, 135);
            LogsTextBox.Name = "LogsTextBox";
            LogsTextBox.ReadOnly = true;
            LogsTextBox.Size = new Size(217, 202);
            LogsTextBox.TabIndex = 5;
            LogsTextBox.Text = "";
            // 
            // DisableBotButton
            // 
            DisableBotButton.Location = new Point(6, 373);
            DisableBotButton.Name = "DisableBotButton";
            DisableBotButton.Size = new Size(217, 42);
            DisableBotButton.TabIndex = 4;
            DisableBotButton.Text = "Отключить бота";
            DisableBotButton.UseVisualStyleBackColor = true;
            DisableBotButton.Click += DisableBotButton_Click;
            // 
            // EnableBotButton
            // 
            EnableBotButton.Location = new Point(6, 72);
            EnableBotButton.Name = "EnableBotButton";
            EnableBotButton.Size = new Size(217, 42);
            EnableBotButton.TabIndex = 3;
            EnableBotButton.Text = "Запустить бота";
            EnableBotButton.UseVisualStyleBackColor = true;
            EnableBotButton.Click += EnableBotButton_Click;
            // 
            // TokenTextBox
            // 
            TokenTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TokenTextBox.Location = new Point(6, 43);
            TokenTextBox.Name = "TokenTextBox";
            TokenTextBox.PlaceholderText = "Токен бота";
            TokenTextBox.Size = new Size(217, 23);
            TokenTextBox.TabIndex = 2;
            TokenTextBox.UseSystemPasswordChar = true;
            // 
            // BotStatusTextLabel
            // 
            BotStatusTextLabel.AutoSize = true;
            BotStatusTextLabel.ForeColor = Color.Red;
            BotStatusTextLabel.Location = new Point(79, 19);
            BotStatusTextLabel.Name = "BotStatusTextLabel";
            BotStatusTextLabel.Size = new Size(64, 15);
            BotStatusTextLabel.TabIndex = 1;
            BotStatusTextLabel.Text = "Отключён";
            // 
            // BotStatusLabel
            // 
            BotStatusLabel.AutoSize = true;
            BotStatusLabel.Location = new Point(6, 19);
            BotStatusLabel.Name = "BotStatusLabel";
            BotStatusLabel.Size = new Size(74, 15);
            BotStatusLabel.TabIndex = 0;
            BotStatusLabel.Text = "Статус бота:";
            // 
            // GamePage
            // 
            GamePage.Location = new Point(4, 24);
            GamePage.Name = "GamePage";
            GamePage.Padding = new Padding(3);
            GamePage.Size = new Size(476, 433);
            GamePage.TabIndex = 1;
            GamePage.Text = "Игра";
            GamePage.UseVisualStyleBackColor = true;
            // 
            // BorderPanel1
            // 
            BorderPanel1.BackColor = Color.Black;
            BorderPanel1.ForeColor = Color.Black;
            BorderPanel1.Location = new Point(77, 109);
            BorderPanel1.Name = "BorderPanel1";
            BorderPanel1.Size = new Size(5, 200);
            BorderPanel1.TabIndex = 1;
            // 
            // BorderPanel2
            // 
            BorderPanel2.BackColor = Color.Black;
            BorderPanel2.ForeColor = Color.Black;
            BorderPanel2.Location = new Point(143, 109);
            BorderPanel2.Name = "BorderPanel2";
            BorderPanel2.Size = new Size(5, 200);
            BorderPanel2.TabIndex = 2;
            // 
            // BorderPanel3
            // 
            BorderPanel3.BackColor = Color.Black;
            BorderPanel3.ForeColor = Color.Black;
            BorderPanel3.Location = new Point(14, 173);
            BorderPanel3.Name = "BorderPanel3";
            BorderPanel3.Size = new Size(200, 5);
            BorderPanel3.TabIndex = 2;
            // 
            // BorderPanel4
            // 
            BorderPanel4.BackColor = Color.Black;
            BorderPanel4.ForeColor = Color.Black;
            BorderPanel4.Location = new Point(14, 239);
            BorderPanel4.Name = "BorderPanel4";
            BorderPanel4.Size = new Size(200, 5);
            BorderPanel4.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(TabControl);
            MinimumSize = new Size(500, 500);
            Name = "MainForm";
            Text = "Крестики-нолики";
            Load += MainForm_Load;
            TabControl.ResumeLayout(false);
            AdminPage.ResumeLayout(false);
            TableLayoutPanel.ResumeLayout(false);
            GameBox.ResumeLayout(false);
            GameViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Cell9).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cell8).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cell7).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cell6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cell5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cell4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cell3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cell2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cell1).EndInit();
            BotBox.ResumeLayout(false);
            BotBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage AdminPage;
        private TabPage GamePage;
        private TableLayoutPanel TableLayoutPanel;
        private GroupBox GameBox;
        private GroupBox BotBox;
        private TextBox TokenTextBox;
        private Label BotStatusTextLabel;
        private Label BotStatusLabel;
        private Button EnableBotButton;
        private Button DisableBotButton;
        private Label LogsLabel;
        private Button ClearLogsButton;
        private RichTextBox LogsTextBox;
        private TableLayoutPanel GameViewPanel;
        private PictureBox Cell1;
        private PictureBox Cell9;
        private PictureBox Cell8;
        private PictureBox Cell7;
        private PictureBox Cell6;
        private PictureBox Cell5;
        private PictureBox Cell4;
        private PictureBox Cell3;
        private PictureBox Cell2;
        private Panel BorderPanel4;
        private Panel BorderPanel3;
        private Panel BorderPanel2;
        private Panel BorderPanel1;
    }
}
