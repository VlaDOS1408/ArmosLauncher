namespace ArmosLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox ConnectionSettingsGroupBox;
            System.Windows.Forms.GroupBox ConnectGroupBox;
            System.Windows.Forms.Label ChooseServerLabel;
            this.btnConnect = new System.Windows.Forms.Button();
            this.ChoosedServerLabel = new System.Windows.Forms.Label();
            this.ServerChooseComboBox = new System.Windows.Forms.ComboBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.DirrectConnectCheckBox = new System.Windows.Forms.CheckBox();
            this.DirrectConnectInputBox = new System.Windows.Forms.TextBox();
            this.DirrectConnectLabel = new System.Windows.Forms.Label();
            this.ServerInfoListBox = new System.Windows.Forms.ListBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ConnectionSettingsGroupBox = new System.Windows.Forms.GroupBox();
            ConnectGroupBox = new System.Windows.Forms.GroupBox();
            ChooseServerLabel = new System.Windows.Forms.Label();
            ConnectionSettingsGroupBox.SuspendLayout();
            ConnectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionSettingsGroupBox
            // 
            ConnectionSettingsGroupBox.Controls.Add(this.DirrectConnectLabel);
            ConnectionSettingsGroupBox.Controls.Add(this.DirrectConnectInputBox);
            ConnectionSettingsGroupBox.Controls.Add(this.DirrectConnectCheckBox);
            ConnectionSettingsGroupBox.Controls.Add(this.ServerChooseComboBox);
            ConnectionSettingsGroupBox.Controls.Add(ChooseServerLabel);
            ConnectionSettingsGroupBox.Location = new System.Drawing.Point(12, 89);
            ConnectionSettingsGroupBox.Name = "ConnectionSettingsGroupBox";
            ConnectionSettingsGroupBox.Size = new System.Drawing.Size(339, 211);
            ConnectionSettingsGroupBox.TabIndex = 0;
            ConnectionSettingsGroupBox.TabStop = false;
            ConnectionSettingsGroupBox.Text = "Connection Settings";
            // 
            // ConnectGroupBox
            // 
            ConnectGroupBox.Controls.Add(this.ChoosedServerLabel);
            ConnectGroupBox.Controls.Add(this.btnConnect);
            ConnectGroupBox.Location = new System.Drawing.Point(357, 211);
            ConnectGroupBox.Name = "ConnectGroupBox";
            ConnectGroupBox.Size = new System.Drawing.Size(244, 89);
            ConnectGroupBox.TabIndex = 1;
            ConnectGroupBox.TabStop = false;
            ConnectGroupBox.Text = "Connect";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(140, 53);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 30);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.toolTip.SetToolTip(this.btnConnect, "Нажмите для подключения");
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ChoosedServerLabel
            // 
            this.ChoosedServerLabel.Location = new System.Drawing.Point(7, 18);
            this.ChoosedServerLabel.Name = "ChoosedServerLabel";
            this.ChoosedServerLabel.Size = new System.Drawing.Size(231, 32);
            this.ChoosedServerLabel.TabIndex = 1;
            this.ChoosedServerLabel.Text = "Вы подключитесь к: 12345678901234567890";
            // 
            // ChooseServerLabel
            // 
            ChooseServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChooseServerLabel.Location = new System.Drawing.Point(9, 21);
            ChooseServerLabel.Name = "ChooseServerLabel";
            ChooseServerLabel.Size = new System.Drawing.Size(80, 28);
            ChooseServerLabel.TabIndex = 0;
            ChooseServerLabel.Text = "Сервер:";
            ChooseServerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServerChooseComboBox
            // 
            this.ServerChooseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerChooseComboBox.FormattingEnabled = true;
            this.ServerChooseComboBox.Items.AddRange(new object[] {
            "АДР - spy.3082",
            "Кирудж - mr.mister1078",
            "Миростария - birddragon"});
            this.ServerChooseComboBox.Location = new System.Drawing.Point(95, 21);
            this.ServerChooseComboBox.Name = "ServerChooseComboBox";
            this.ServerChooseComboBox.Size = new System.Drawing.Size(238, 26);
            this.ServerChooseComboBox.Sorted = true;
            this.ServerChooseComboBox.TabIndex = 1;
            this.ServerChooseComboBox.Text = "Выберите сервер";
            this.toolTip.SetToolTip(this.ServerChooseComboBox, "Выберите сервер для игры из предложенного списка");
            // 
            // MainLabel
            // 
            this.MainLabel.Font = new System.Drawing.Font("Molot", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(12, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(589, 77);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "ARMOS LAUNCHER";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DirrectConnectCheckBox
            // 
            this.DirrectConnectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirrectConnectCheckBox.Location = new System.Drawing.Point(16, 80);
            this.DirrectConnectCheckBox.Name = "DirrectConnectCheckBox";
            this.DirrectConnectCheckBox.Size = new System.Drawing.Size(196, 24);
            this.DirrectConnectCheckBox.TabIndex = 2;
            this.DirrectConnectCheckBox.Text = "Прямое подключение";
            this.DirrectConnectCheckBox.UseVisualStyleBackColor = true;
            // 
            // DirrectConnectInputBox
            // 
            this.DirrectConnectInputBox.Enabled = false;
            this.DirrectConnectInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirrectConnectInputBox.Location = new System.Drawing.Point(167, 53);
            this.DirrectConnectInputBox.MaxLength = 17;
            this.DirrectConnectInputBox.Name = "DirrectConnectInputBox";
            this.DirrectConnectInputBox.Size = new System.Drawing.Size(166, 24);
            this.DirrectConnectInputBox.TabIndex = 3;
            this.DirrectConnectInputBox.Text = "12345678901234567";
            this.toolTip.SetToolTip(this.DirrectConnectInputBox, "Введите Steam ID пользователя к которому вы хотите присоединится");
            // 
            // DirrectConnectLabel
            // 
            this.DirrectConnectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirrectConnectLabel.Location = new System.Drawing.Point(12, 54);
            this.DirrectConnectLabel.Name = "DirrectConnectLabel";
            this.DirrectConnectLabel.Size = new System.Drawing.Size(149, 23);
            this.DirrectConnectLabel.TabIndex = 4;
            this.DirrectConnectLabel.Text = "Steam ID:";
            this.DirrectConnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServerInfoListBox
            // 
            this.ServerInfoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerInfoListBox.HorizontalScrollbar = true;
            this.ServerInfoListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ServerInfoListBox.ItemHeight = 16;
            this.ServerInfoListBox.Items.AddRange(new object[] {
            "Какая-то информация о сервере",
            "Строка 1",
            "Строка 2",
            "Строка 3",
            "Строка 4",
            "Строка 5"});
            this.ServerInfoListBox.Location = new System.Drawing.Point(357, 98);
            this.ServerInfoListBox.Name = "ServerInfoListBox";
            this.ServerInfoListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ServerInfoListBox.Size = new System.Drawing.Size(244, 100);
            this.ServerInfoListBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 312);
            this.Controls.Add(this.ServerInfoListBox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(ConnectGroupBox);
            this.Controls.Add(ConnectionSettingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Armos Launcher v0.04";
            ConnectionSettingsGroupBox.ResumeLayout(false);
            ConnectionSettingsGroupBox.PerformLayout();
            ConnectGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label ChoosedServerLabel;
        private System.Windows.Forms.ComboBox ServerChooseComboBox;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.CheckBox DirrectConnectCheckBox;
        private System.Windows.Forms.TextBox DirrectConnectInputBox;
        private System.Windows.Forms.Label DirrectConnectLabel;
        private System.Windows.Forms.ListBox ServerInfoListBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

