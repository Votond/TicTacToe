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
            BotBox = new GroupBox();
            DisableBotButton = new Button();
            EnableBotButton = new Button();
            TokenTextBox = new TextBox();
            BotStatusTextLabel = new Label();
            BotStatusLabel = new Label();
            GamePage = new TabPage();
            TabControl.SuspendLayout();
            AdminPage.SuspendLayout();
            TableLayoutPanel.SuspendLayout();
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
            GameBox.Dock = DockStyle.Fill;
            GameBox.Location = new Point(238, 3);
            GameBox.Name = "GameBox";
            GameBox.Size = new Size(229, 421);
            GameBox.TabIndex = 1;
            GameBox.TabStop = false;
            GameBox.Text = "Игра";
            // 
            // BotBox
            // 
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
            BotStatusTextLabel.Location = new Point(86, 19);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(TabControl);
            MinimumSize = new Size(500, 500);
            Name = "MainForm";
            Text = "Крестики-нолики";
            TabControl.ResumeLayout(false);
            AdminPage.ResumeLayout(false);
            TableLayoutPanel.ResumeLayout(false);
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
    }
}
