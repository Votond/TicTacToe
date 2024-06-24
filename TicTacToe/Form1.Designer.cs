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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TabControl = new TabControl();
            AdminPage = new TabPage();
            ClearLogsButton = new Button();
            LogsTextBox = new RichTextBox();
            LogsLabel = new Label();
            DisableBotButton = new Button();
            TokenTextBox = new TextBox();
            BotStatusTextLabel = new Label();
            BotStatusLabel = new Label();
            EnableBotButton = new Button();
            GamePage = new TabPage();
            GameRulesLabel = new Label();
            GameRulesTextBox = new TextBox();
            GameDescLabel = new Label();
            GameDescTextBox = new TextBox();
            TabControl.SuspendLayout();
            AdminPage.SuspendLayout();
            GamePage.SuspendLayout();
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
            TabControl.Size = new Size(484, 438);
            TabControl.TabIndex = 0;
            // 
            // AdminPage
            // 
            AdminPage.Controls.Add(ClearLogsButton);
            AdminPage.Controls.Add(LogsTextBox);
            AdminPage.Controls.Add(LogsLabel);
            AdminPage.Controls.Add(DisableBotButton);
            AdminPage.Controls.Add(TokenTextBox);
            AdminPage.Controls.Add(BotStatusTextLabel);
            AdminPage.Controls.Add(BotStatusLabel);
            AdminPage.Controls.Add(EnableBotButton);
            AdminPage.Location = new Point(4, 24);
            AdminPage.Name = "AdminPage";
            AdminPage.Padding = new Padding(3);
            AdminPage.Size = new Size(476, 410);
            AdminPage.TabIndex = 0;
            AdminPage.Text = "Админ панель";
            AdminPage.UseVisualStyleBackColor = true;
            // 
            // ClearLogsButton
            // 
            ClearLogsButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ClearLogsButton.BackColor = Color.FromArgb(80, 32, 108);
            ClearLogsButton.FlatStyle = FlatStyle.Flat;
            ClearLogsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearLogsButton.ForeColor = Color.White;
            ClearLogsButton.Location = new Point(177, 329);
            ClearLogsButton.Name = "ClearLogsButton";
            ClearLogsButton.Size = new Size(122, 24);
            ClearLogsButton.TabIndex = 7;
            ClearLogsButton.Text = "Очистить логи";
            ClearLogsButton.UseVisualStyleBackColor = false;
            ClearLogsButton.Click += ClearLogsButton_Click;
            // 
            // LogsTextBox
            // 
            LogsTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LogsTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LogsTextBox.ForeColor = Color.FromArgb(80, 32, 108);
            LogsTextBox.Location = new Point(10, 122);
            LogsTextBox.Name = "LogsTextBox";
            LogsTextBox.ReadOnly = true;
            LogsTextBox.Size = new Size(458, 202);
            LogsTextBox.TabIndex = 5;
            LogsTextBox.Text = "";
            // 
            // LogsLabel
            // 
            LogsLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LogsLabel.Location = new Point(221, 103);
            LogsLabel.Name = "LogsLabel";
            LogsLabel.Size = new Size(34, 15);
            LogsLabel.TabIndex = 6;
            LogsLabel.Text = "Логи";
            LogsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DisableBotButton
            // 
            DisableBotButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DisableBotButton.BackColor = Color.FromArgb(80, 32, 108);
            DisableBotButton.FlatStyle = FlatStyle.Flat;
            DisableBotButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DisableBotButton.ForeColor = Color.White;
            DisableBotButton.Location = new Point(10, 360);
            DisableBotButton.Name = "DisableBotButton";
            DisableBotButton.Size = new Size(458, 42);
            DisableBotButton.TabIndex = 4;
            DisableBotButton.Text = "Отключить бота";
            DisableBotButton.UseVisualStyleBackColor = false;
            DisableBotButton.Click += DisableBotButton_Click;
            // 
            // TokenTextBox
            // 
            TokenTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TokenTextBox.Location = new Point(10, 30);
            TokenTextBox.Name = "TokenTextBox";
            TokenTextBox.PlaceholderText = "Токен бота";
            TokenTextBox.Size = new Size(458, 23);
            TokenTextBox.TabIndex = 2;
            TokenTextBox.UseSystemPasswordChar = true;
            // 
            // BotStatusTextLabel
            // 
            BotStatusTextLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BotStatusTextLabel.AutoSize = true;
            BotStatusTextLabel.ForeColor = Color.Red;
            BotStatusTextLabel.Location = new Point(90, 3);
            BotStatusTextLabel.Name = "BotStatusTextLabel";
            BotStatusTextLabel.Size = new Size(64, 15);
            BotStatusTextLabel.TabIndex = 1;
            BotStatusTextLabel.Text = "Отключён";
            // 
            // BotStatusLabel
            // 
            BotStatusLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BotStatusLabel.AutoSize = true;
            BotStatusLabel.Location = new Point(10, 3);
            BotStatusLabel.Name = "BotStatusLabel";
            BotStatusLabel.Size = new Size(74, 15);
            BotStatusLabel.TabIndex = 0;
            BotStatusLabel.Text = "Статус бота:";
            // 
            // EnableBotButton
            // 
            EnableBotButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EnableBotButton.BackColor = Color.FromArgb(80, 32, 108);
            EnableBotButton.FlatStyle = FlatStyle.Flat;
            EnableBotButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EnableBotButton.ForeColor = Color.White;
            EnableBotButton.Location = new Point(10, 59);
            EnableBotButton.Name = "EnableBotButton";
            EnableBotButton.Size = new Size(458, 42);
            EnableBotButton.TabIndex = 3;
            EnableBotButton.Text = "Запустить бота";
            EnableBotButton.UseVisualStyleBackColor = false;
            EnableBotButton.Click += EnableBotButton_Click;
            // 
            // GamePage
            // 
            GamePage.Controls.Add(GameRulesLabel);
            GamePage.Controls.Add(GameRulesTextBox);
            GamePage.Controls.Add(GameDescLabel);
            GamePage.Controls.Add(GameDescTextBox);
            GamePage.Location = new Point(4, 24);
            GamePage.Name = "GamePage";
            GamePage.Padding = new Padding(3);
            GamePage.Size = new Size(476, 410);
            GamePage.TabIndex = 1;
            GamePage.Text = "Игра";
            GamePage.UseVisualStyleBackColor = true;
            // 
            // GameRulesLabel
            // 
            GameRulesLabel.AutoSize = true;
            GameRulesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GameRulesLabel.ForeColor = Color.FromArgb(80, 32, 108);
            GameRulesLabel.Location = new Point(7, 98);
            GameRulesLabel.Name = "GameRulesLabel";
            GameRulesLabel.Size = new Size(74, 21);
            GameRulesLabel.TabIndex = 11;
            GameRulesLabel.Text = "Правила:";
            // 
            // GameRulesTextBox
            // 
            GameRulesTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            GameRulesTextBox.BackColor = Color.White;
            GameRulesTextBox.BorderStyle = BorderStyle.None;
            GameRulesTextBox.Location = new Point(8, 120);
            GameRulesTextBox.Multiline = true;
            GameRulesTextBox.Name = "GameRulesTextBox";
            GameRulesTextBox.ReadOnly = true;
            GameRulesTextBox.Size = new Size(458, 140);
            GameRulesTextBox.TabIndex = 10;
            GameRulesTextBox.Text = resources.GetString("GameRulesTextBox.Text");
            // 
            // GameDescLabel
            // 
            GameDescLabel.AutoSize = true;
            GameDescLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GameDescLabel.ForeColor = Color.FromArgb(80, 32, 108);
            GameDescLabel.Location = new Point(6, 3);
            GameDescLabel.Name = "GameDescLabel";
            GameDescLabel.Size = new Size(84, 21);
            GameDescLabel.TabIndex = 9;
            GameDescLabel.Text = "Описание:";
            // 
            // GameDescTextBox
            // 
            GameDescTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            GameDescTextBox.BackColor = Color.White;
            GameDescTextBox.BorderStyle = BorderStyle.None;
            GameDescTextBox.ForeColor = SystemColors.WindowText;
            GameDescTextBox.Location = new Point(8, 25);
            GameDescTextBox.Multiline = true;
            GameDescTextBox.Name = "GameDescTextBox";
            GameDescTextBox.ReadOnly = true;
            GameDescTextBox.Size = new Size(458, 50);
            GameDescTextBox.TabIndex = 8;
            GameDescTextBox.Text = resources.GetString("GameDescTextBox.Text");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 438);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(9999, 477);
            MinimumSize = new Size(500, 477);
            Name = "MainForm";
            Text = "Крестики-нолики";
            Load += MainForm_Load;
            TabControl.ResumeLayout(false);
            AdminPage.ResumeLayout(false);
            AdminPage.PerformLayout();
            GamePage.ResumeLayout(false);
            GamePage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage AdminPage;
        private TabPage GamePage;
        private TextBox TokenTextBox;
        private Label BotStatusTextLabel;
        private Label BotStatusLabel;
        private Button EnableBotButton;
        private Button DisableBotButton;
        private Label LogsLabel;
        private Button ClearLogsButton;
        private RichTextBox LogsTextBox;
        private TextBox GameDescTextBox;
        private Label GameDescLabel;
        private Label GameRulesLabel;
        private TextBox GameRulesTextBox;
    }
}
