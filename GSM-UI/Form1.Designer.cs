namespace GSM_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.callBtn = new System.Windows.Forms.Button();
            this.hangupBtn = new System.Windows.Forms.Button();
            this.dialTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.voiceCallTab = new System.Windows.Forms.TabPage();
            this.incomingVoiceCallGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.answerBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OutgoingVoiceCallGroupBox = new System.Windows.Forms.GroupBox();
            this.redialButton = new System.Windows.Forms.Button();
            this.callNumberLabel = new System.Windows.Forms.Label();
            this.dataReceivedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.smsTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.smsMessageTab = new System.Windows.Forms.TabPage();
            this.smsInboxTab = new System.Windows.Forms.TabPage();
            this.smsSettingsTab = new System.Windows.Forms.TabPage();
            this.smsMessagePhoneNumberLabel = new System.Windows.Forms.Label();
            this.smsMessagePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.smsMessageGroup = new System.Windows.Forms.GroupBox();
            this.smsMessageTextBox = new System.Windows.Forms.TextBox();
            this.smsMessageLabel = new System.Windows.Forms.Label();
            this.smsMessageShowPDUFormatButton = new System.Windows.Forms.Button();
            this.smsMessageSendSmsButton = new System.Windows.Forms.Button();
            this.smsMessageShowTextFormatButton = new System.Windows.Forms.Button();
            this.connectionGroup = new System.Windows.Forms.GroupBox();
            this.saveLogButton = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.connectionDeviceModelLabel = new System.Windows.Forms.Label();
            this.connectionManufacturerLabel = new System.Windows.Forms.Label();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.smsSettingsGroup = new System.Windows.Forms.GroupBox();
            this.smsSettingsPDUGroup = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.smsSettingsSmsModeLabel = new System.Windows.Forms.Label();
            this.smsSettingsSmsServiceCenterLabel = new System.Windows.Forms.Label();
            this.smsSettingsSmsServiceCenterTextBox = new System.Windows.Forms.TextBox();
            this.smsSettingsSmsModeSetButton = new System.Windows.Forms.Button();
            this.smsSettingsSmsModeGetButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.voiceCallTab.SuspendLayout();
            this.incomingVoiceCallGroupBox.SuspendLayout();
            this.OutgoingVoiceCallGroupBox.SuspendLayout();
            this.smsTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.smsMessageTab.SuspendLayout();
            this.smsSettingsTab.SuspendLayout();
            this.smsMessageGroup.SuspendLayout();
            this.connectionGroup.SuspendLayout();
            this.smsSettingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(158, 63);
            this.cmdTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(196, 31);
            this.cmdTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(370, 60);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(150, 44);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // callBtn
            // 
            this.callBtn.Location = new System.Drawing.Point(140, 137);
            this.callBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.callBtn.Name = "callBtn";
            this.callBtn.Size = new System.Drawing.Size(150, 44);
            this.callBtn.TabIndex = 4;
            this.callBtn.Text = "Dial";
            this.callBtn.UseVisualStyleBackColor = true;
            this.callBtn.Click += new System.EventHandler(this.CallBtn_Click);
            // 
            // hangupBtn
            // 
            this.hangupBtn.Location = new System.Drawing.Point(302, 137);
            this.hangupBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hangupBtn.Name = "hangupBtn";
            this.hangupBtn.Size = new System.Drawing.Size(150, 44);
            this.hangupBtn.TabIndex = 6;
            this.hangupBtn.Text = "Hang Up";
            this.hangupBtn.UseVisualStyleBackColor = true;
            this.hangupBtn.Click += new System.EventHandler(this.HangupBtn_Click);
            // 
            // dialTextBox
            // 
            this.dialTextBox.Location = new System.Drawing.Point(212, 71);
            this.dialTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dialTextBox.Name = "dialTextBox";
            this.dialTextBox.Size = new System.Drawing.Size(196, 31);
            this.dialTextBox.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.voiceCallTab);
            this.tabControl1.Controls.Add(this.smsTab);
            this.tabControl1.Location = new System.Drawing.Point(21, 295);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 731);
            this.tabControl1.TabIndex = 8;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.label1);
            this.mainTab.Controls.Add(this.cmdTextBox);
            this.mainTab.Controls.Add(this.sendBtn);
            this.mainTab.Location = new System.Drawing.Point(8, 39);
            this.mainTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mainTab.Size = new System.Drawing.Size(982, 684);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // voiceCallTab
            // 
            this.voiceCallTab.Controls.Add(this.incomingVoiceCallGroupBox);
            this.voiceCallTab.Controls.Add(this.OutgoingVoiceCallGroupBox);
            this.voiceCallTab.Location = new System.Drawing.Point(8, 39);
            this.voiceCallTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.voiceCallTab.Name = "voiceCallTab";
            this.voiceCallTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.voiceCallTab.Size = new System.Drawing.Size(982, 684);
            this.voiceCallTab.TabIndex = 1;
            this.voiceCallTab.Text = "Voice Call";
            this.voiceCallTab.UseVisualStyleBackColor = true;
            // 
            // incomingVoiceCallGroupBox
            // 
            this.incomingVoiceCallGroupBox.Controls.Add(this.phoneNumberLabel);
            this.incomingVoiceCallGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.incomingVoiceCallGroupBox.Controls.Add(this.answerBtn);
            this.incomingVoiceCallGroupBox.Controls.Add(this.button1);
            this.incomingVoiceCallGroupBox.Location = new System.Drawing.Point(46, 360);
            this.incomingVoiceCallGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.incomingVoiceCallGroupBox.Name = "incomingVoiceCallGroupBox";
            this.incomingVoiceCallGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.incomingVoiceCallGroupBox.Size = new System.Drawing.Size(854, 210);
            this.incomingVoiceCallGroupBox.TabIndex = 9;
            this.incomingVoiceCallGroupBox.TabStop = false;
            this.incomingVoiceCallGroupBox.Text = "Incoming";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(44, 77);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(155, 25);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Enabled = false;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(212, 71);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.ReadOnly = true;
            this.phoneNumberTextBox.Size = new System.Drawing.Size(196, 31);
            this.phoneNumberTextBox.TabIndex = 7;
            // 
            // answerBtn
            // 
            this.answerBtn.Location = new System.Drawing.Point(140, 137);
            this.answerBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(150, 44);
            this.answerBtn.TabIndex = 5;
            this.answerBtn.Text = "Answer";
            this.answerBtn.UseVisualStyleBackColor = true;
            this.answerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hang Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OutgoingVoiceCallGroupBox
            // 
            this.OutgoingVoiceCallGroupBox.Controls.Add(this.redialButton);
            this.OutgoingVoiceCallGroupBox.Controls.Add(this.callNumberLabel);
            this.OutgoingVoiceCallGroupBox.Controls.Add(this.dialTextBox);
            this.OutgoingVoiceCallGroupBox.Controls.Add(this.hangupBtn);
            this.OutgoingVoiceCallGroupBox.Controls.Add(this.callBtn);
            this.OutgoingVoiceCallGroupBox.Location = new System.Drawing.Point(46, 104);
            this.OutgoingVoiceCallGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OutgoingVoiceCallGroupBox.Name = "OutgoingVoiceCallGroupBox";
            this.OutgoingVoiceCallGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OutgoingVoiceCallGroupBox.Size = new System.Drawing.Size(854, 210);
            this.OutgoingVoiceCallGroupBox.TabIndex = 8;
            this.OutgoingVoiceCallGroupBox.TabStop = false;
            this.OutgoingVoiceCallGroupBox.Text = "Outgoing";
            // 
            // redialButton
            // 
            this.redialButton.Location = new System.Drawing.Point(652, 67);
            this.redialButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.redialButton.Name = "redialButton";
            this.redialButton.Size = new System.Drawing.Size(150, 44);
            this.redialButton.TabIndex = 9;
            this.redialButton.Text = "Redial";
            this.redialButton.UseVisualStyleBackColor = true;
            // 
            // callNumberLabel
            // 
            this.callNumberLabel.AutoSize = true;
            this.callNumberLabel.Location = new System.Drawing.Point(44, 77);
            this.callNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.callNumberLabel.Name = "callNumberLabel";
            this.callNumberLabel.Size = new System.Drawing.Size(130, 25);
            this.callNumberLabel.TabIndex = 8;
            this.callNumberLabel.Text = "Call Number";
            // 
            // dataReceivedRichTextBox
            // 
            this.dataReceivedRichTextBox.Location = new System.Drawing.Point(1031, 337);
            this.dataReceivedRichTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataReceivedRichTextBox.Name = "dataReceivedRichTextBox";
            this.dataReceivedRichTextBox.ReadOnly = true;
            this.dataReceivedRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.dataReceivedRichTextBox.Size = new System.Drawing.Size(538, 677);
            this.dataReceivedRichTextBox.TabIndex = 9;
            this.dataReceivedRichTextBox.Text = "";
            // 
            // smsTab
            // 
            this.smsTab.Controls.Add(this.tabControl2);
            this.smsTab.Location = new System.Drawing.Point(8, 39);
            this.smsTab.Name = "smsTab";
            this.smsTab.Padding = new System.Windows.Forms.Padding(3);
            this.smsTab.Size = new System.Drawing.Size(982, 684);
            this.smsTab.TabIndex = 2;
            this.smsTab.Text = "SMS";
            this.smsTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.smsMessageTab);
            this.tabControl2.Controls.Add(this.smsInboxTab);
            this.tabControl2.Controls.Add(this.smsSettingsTab);
            this.tabControl2.Location = new System.Drawing.Point(6, 55);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(970, 623);
            this.tabControl2.TabIndex = 0;
            // 
            // smsMessageTab
            // 
            this.smsMessageTab.Controls.Add(this.smsMessageGroup);
            this.smsMessageTab.Location = new System.Drawing.Point(8, 39);
            this.smsMessageTab.Name = "smsMessageTab";
            this.smsMessageTab.Padding = new System.Windows.Forms.Padding(3);
            this.smsMessageTab.Size = new System.Drawing.Size(954, 576);
            this.smsMessageTab.TabIndex = 0;
            this.smsMessageTab.Text = "Message";
            this.smsMessageTab.UseVisualStyleBackColor = true;
            // 
            // smsInboxTab
            // 
            this.smsInboxTab.Location = new System.Drawing.Point(8, 39);
            this.smsInboxTab.Name = "smsInboxTab";
            this.smsInboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.smsInboxTab.Size = new System.Drawing.Size(954, 625);
            this.smsInboxTab.TabIndex = 1;
            this.smsInboxTab.Text = "Inbox";
            this.smsInboxTab.UseVisualStyleBackColor = true;
            // 
            // smsSettingsTab
            // 
            this.smsSettingsTab.Controls.Add(this.smsSettingsPDUGroup);
            this.smsSettingsTab.Controls.Add(this.smsSettingsGroup);
            this.smsSettingsTab.Location = new System.Drawing.Point(8, 39);
            this.smsSettingsTab.Name = "smsSettingsTab";
            this.smsSettingsTab.Size = new System.Drawing.Size(954, 576);
            this.smsSettingsTab.TabIndex = 2;
            this.smsSettingsTab.Text = "Settings";
            this.smsSettingsTab.UseVisualStyleBackColor = true;
            // 
            // smsMessagePhoneNumberLabel
            // 
            this.smsMessagePhoneNumberLabel.AutoSize = true;
            this.smsMessagePhoneNumberLabel.Location = new System.Drawing.Point(9, 48);
            this.smsMessagePhoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.smsMessagePhoneNumberLabel.Name = "smsMessagePhoneNumberLabel";
            this.smsMessagePhoneNumberLabel.Size = new System.Drawing.Size(155, 25);
            this.smsMessagePhoneNumberLabel.TabIndex = 10;
            this.smsMessagePhoneNumberLabel.Text = "Phone Number";
            // 
            // smsMessagePhoneNumberTextBox
            // 
            this.smsMessagePhoneNumberTextBox.Location = new System.Drawing.Point(176, 45);
            this.smsMessagePhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.smsMessagePhoneNumberTextBox.Name = "smsMessagePhoneNumberTextBox";
            this.smsMessagePhoneNumberTextBox.Size = new System.Drawing.Size(196, 31);
            this.smsMessagePhoneNumberTextBox.TabIndex = 9;
            // 
            // smsMessageGroup
            // 
            this.smsMessageGroup.Controls.Add(this.smsMessageShowTextFormatButton);
            this.smsMessageGroup.Controls.Add(this.smsMessageShowPDUFormatButton);
            this.smsMessageGroup.Controls.Add(this.smsMessageLabel);
            this.smsMessageGroup.Controls.Add(this.smsMessageSendSmsButton);
            this.smsMessageGroup.Controls.Add(this.smsMessageTextBox);
            this.smsMessageGroup.Controls.Add(this.smsMessagePhoneNumberLabel);
            this.smsMessageGroup.Controls.Add(this.smsMessagePhoneNumberTextBox);
            this.smsMessageGroup.Location = new System.Drawing.Point(21, 24);
            this.smsMessageGroup.Name = "smsMessageGroup";
            this.smsMessageGroup.Size = new System.Drawing.Size(903, 301);
            this.smsMessageGroup.TabIndex = 11;
            this.smsMessageGroup.TabStop = false;
            // 
            // smsMessageTextBox
            // 
            this.smsMessageTextBox.Location = new System.Drawing.Point(14, 118);
            this.smsMessageTextBox.Multiline = true;
            this.smsMessageTextBox.Name = "smsMessageTextBox";
            this.smsMessageTextBox.Size = new System.Drawing.Size(853, 96);
            this.smsMessageTextBox.TabIndex = 11;
            // 
            // smsMessageLabel
            // 
            this.smsMessageLabel.AutoSize = true;
            this.smsMessageLabel.Location = new System.Drawing.Point(9, 90);
            this.smsMessageLabel.Name = "smsMessageLabel";
            this.smsMessageLabel.Size = new System.Drawing.Size(100, 25);
            this.smsMessageLabel.TabIndex = 12;
            this.smsMessageLabel.Text = "Message";
            // 
            // smsMessageShowPDUFormatButton
            // 
            this.smsMessageShowPDUFormatButton.Location = new System.Drawing.Point(176, 236);
            this.smsMessageShowPDUFormatButton.Margin = new System.Windows.Forms.Padding(6);
            this.smsMessageShowPDUFormatButton.Name = "smsMessageShowPDUFormatButton";
            this.smsMessageShowPDUFormatButton.Size = new System.Drawing.Size(222, 44);
            this.smsMessageShowPDUFormatButton.TabIndex = 13;
            this.smsMessageShowPDUFormatButton.Text = "Show PDU Format";
            this.smsMessageShowPDUFormatButton.UseVisualStyleBackColor = true;
            // 
            // smsMessageSendSmsButton
            // 
            this.smsMessageSendSmsButton.Location = new System.Drawing.Point(14, 236);
            this.smsMessageSendSmsButton.Margin = new System.Windows.Forms.Padding(6);
            this.smsMessageSendSmsButton.Name = "smsMessageSendSmsButton";
            this.smsMessageSendSmsButton.Size = new System.Drawing.Size(150, 44);
            this.smsMessageSendSmsButton.TabIndex = 12;
            this.smsMessageSendSmsButton.Text = "Send SMS";
            this.smsMessageSendSmsButton.UseVisualStyleBackColor = true;
            // 
            // smsMessageShowTextFormatButton
            // 
            this.smsMessageShowTextFormatButton.Location = new System.Drawing.Point(410, 236);
            this.smsMessageShowTextFormatButton.Margin = new System.Windows.Forms.Padding(6);
            this.smsMessageShowTextFormatButton.Name = "smsMessageShowTextFormatButton";
            this.smsMessageShowTextFormatButton.Size = new System.Drawing.Size(223, 44);
            this.smsMessageShowTextFormatButton.TabIndex = 14;
            this.smsMessageShowTextFormatButton.Text = "Show Text Format";
            this.smsMessageShowTextFormatButton.UseVisualStyleBackColor = true;
            // 
            // connectionGroup
            // 
            this.connectionGroup.Controls.Add(this.connectionStatusLabel);
            this.connectionGroup.Controls.Add(this.connectionManufacturerLabel);
            this.connectionGroup.Controls.Add(this.connectionDeviceModelLabel);
            this.connectionGroup.Location = new System.Drawing.Point(1115, 12);
            this.connectionGroup.Name = "connectionGroup";
            this.connectionGroup.Size = new System.Drawing.Size(464, 193);
            this.connectionGroup.TabIndex = 10;
            this.connectionGroup.TabStop = false;
            this.connectionGroup.Text = "Connection";
            // 
            // saveLogButton
            // 
            this.saveLogButton.Location = new System.Drawing.Point(1419, 281);
            this.saveLogButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveLogButton.Name = "saveLogButton";
            this.saveLogButton.Size = new System.Drawing.Size(150, 44);
            this.saveLogButton.TabIndex = 11;
            this.saveLogButton.Text = "Save Log";
            this.saveLogButton.UseVisualStyleBackColor = true;
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(1257, 281);
            this.clearLogButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(150, 44);
            this.clearLogButton.TabIndex = 10;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            // 
            // connectionDeviceModelLabel
            // 
            this.connectionDeviceModelLabel.AutoSize = true;
            this.connectionDeviceModelLabel.Location = new System.Drawing.Point(21, 53);
            this.connectionDeviceModelLabel.Name = "connectionDeviceModelLabel";
            this.connectionDeviceModelLabel.Size = new System.Drawing.Size(143, 25);
            this.connectionDeviceModelLabel.TabIndex = 0;
            this.connectionDeviceModelLabel.Text = "Device Model";
            // 
            // connectionManufacturerLabel
            // 
            this.connectionManufacturerLabel.AutoSize = true;
            this.connectionManufacturerLabel.Location = new System.Drawing.Point(21, 94);
            this.connectionManufacturerLabel.Name = "connectionManufacturerLabel";
            this.connectionManufacturerLabel.Size = new System.Drawing.Size(139, 25);
            this.connectionManufacturerLabel.TabIndex = 1;
            this.connectionManufacturerLabel.Text = "Manufacturer";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(21, 133);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(73, 25);
            this.connectionStatusLabel.TabIndex = 2;
            this.connectionStatusLabel.Text = "Status";
            // 
            // smsSettingsGroup
            // 
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsModeSetButton);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsServiceCenterTextBox);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsModeGetButton);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsServiceCenterLabel);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsModeLabel);
            this.smsSettingsGroup.Controls.Add(this.comboBox1);
            this.smsSettingsGroup.Location = new System.Drawing.Point(45, 46);
            this.smsSettingsGroup.Name = "smsSettingsGroup";
            this.smsSettingsGroup.Size = new System.Drawing.Size(835, 172);
            this.smsSettingsGroup.TabIndex = 0;
            this.smsSettingsGroup.TabStop = false;
            // 
            // smsSettingsPDUGroup
            // 
            this.smsSettingsPDUGroup.Location = new System.Drawing.Point(45, 248);
            this.smsSettingsPDUGroup.Name = "smsSettingsPDUGroup";
            this.smsSettingsPDUGroup.Size = new System.Drawing.Size(835, 302);
            this.smsSettingsPDUGroup.TabIndex = 1;
            this.smsSettingsPDUGroup.TabStop = false;
            this.smsSettingsPDUGroup.Text = "PDU Settings";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Text",
            "PDU"});
            this.comboBox1.Location = new System.Drawing.Point(281, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // smsSettingsSmsModeLabel
            // 
            this.smsSettingsSmsModeLabel.AutoSize = true;
            this.smsSettingsSmsModeLabel.Location = new System.Drawing.Point(23, 51);
            this.smsSettingsSmsModeLabel.Name = "smsSettingsSmsModeLabel";
            this.smsSettingsSmsModeLabel.Size = new System.Drawing.Size(118, 25);
            this.smsSettingsSmsModeLabel.TabIndex = 2;
            this.smsSettingsSmsModeLabel.Text = "SMS Mode";
            // 
            // smsSettingsSmsServiceCenterLabel
            // 
            this.smsSettingsSmsServiceCenterLabel.AutoSize = true;
            this.smsSettingsSmsServiceCenterLabel.Location = new System.Drawing.Point(23, 108);
            this.smsSettingsSmsServiceCenterLabel.Name = "smsSettingsSmsServiceCenterLabel";
            this.smsSettingsSmsServiceCenterLabel.Size = new System.Drawing.Size(206, 25);
            this.smsSettingsSmsServiceCenterLabel.TabIndex = 3;
            this.smsSettingsSmsServiceCenterLabel.Text = "SMS Service Center";
            // 
            // smsSettingsSmsServiceCenterTextBox
            // 
            this.smsSettingsSmsServiceCenterTextBox.Location = new System.Drawing.Point(281, 105);
            this.smsSettingsSmsServiceCenterTextBox.Name = "smsSettingsSmsServiceCenterTextBox";
            this.smsSettingsSmsServiceCenterTextBox.Size = new System.Drawing.Size(172, 31);
            this.smsSettingsSmsServiceCenterTextBox.TabIndex = 4;
            // 
            // smsSettingsSmsModeSetButton
            // 
            this.smsSettingsSmsModeSetButton.Location = new System.Drawing.Point(668, 41);
            this.smsSettingsSmsModeSetButton.Margin = new System.Windows.Forms.Padding(6);
            this.smsSettingsSmsModeSetButton.Name = "smsSettingsSmsModeSetButton";
            this.smsSettingsSmsModeSetButton.Size = new System.Drawing.Size(150, 44);
            this.smsSettingsSmsModeSetButton.TabIndex = 13;
            this.smsSettingsSmsModeSetButton.Text = "Set";
            this.smsSettingsSmsModeSetButton.UseVisualStyleBackColor = true;
            // 
            // smsSettingsSmsModeGetButton
            // 
            this.smsSettingsSmsModeGetButton.Location = new System.Drawing.Point(506, 41);
            this.smsSettingsSmsModeGetButton.Margin = new System.Windows.Forms.Padding(6);
            this.smsSettingsSmsModeGetButton.Name = "smsSettingsSmsModeGetButton";
            this.smsSettingsSmsModeGetButton.Size = new System.Drawing.Size(150, 44);
            this.smsSettingsSmsModeGetButton.TabIndex = 12;
            this.smsSettingsSmsModeGetButton.Text = "Get";
            this.smsSettingsSmsModeGetButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1041);
            this.Controls.Add(this.saveLogButton);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.connectionGroup);
            this.Controls.Add(this.dataReceivedRichTextBox);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "GSM Tester";
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.voiceCallTab.ResumeLayout(false);
            this.incomingVoiceCallGroupBox.ResumeLayout(false);
            this.incomingVoiceCallGroupBox.PerformLayout();
            this.OutgoingVoiceCallGroupBox.ResumeLayout(false);
            this.OutgoingVoiceCallGroupBox.PerformLayout();
            this.smsTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.smsMessageTab.ResumeLayout(false);
            this.smsSettingsTab.ResumeLayout(false);
            this.smsMessageGroup.ResumeLayout(false);
            this.smsMessageGroup.PerformLayout();
            this.connectionGroup.ResumeLayout(false);
            this.connectionGroup.PerformLayout();
            this.smsSettingsGroup.ResumeLayout(false);
            this.smsSettingsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button callBtn;
        private System.Windows.Forms.Button hangupBtn;
        private System.Windows.Forms.TextBox dialTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage voiceCallTab;
        private System.Windows.Forms.GroupBox incomingVoiceCallGroupBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button answerBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox OutgoingVoiceCallGroupBox;
        private System.Windows.Forms.Label callNumberLabel;
        private System.Windows.Forms.RichTextBox dataReceivedRichTextBox;
        private System.Windows.Forms.Button redialButton;
        private System.Windows.Forms.TabPage smsTab;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage smsMessageTab;
        private System.Windows.Forms.GroupBox smsMessageGroup;
        private System.Windows.Forms.Button smsMessageShowTextFormatButton;
        private System.Windows.Forms.Button smsMessageShowPDUFormatButton;
        private System.Windows.Forms.Label smsMessageLabel;
        private System.Windows.Forms.Button smsMessageSendSmsButton;
        private System.Windows.Forms.TextBox smsMessageTextBox;
        private System.Windows.Forms.Label smsMessagePhoneNumberLabel;
        private System.Windows.Forms.TextBox smsMessagePhoneNumberTextBox;
        private System.Windows.Forms.TabPage smsInboxTab;
        private System.Windows.Forms.TabPage smsSettingsTab;
        private System.Windows.Forms.GroupBox smsSettingsPDUGroup;
        private System.Windows.Forms.GroupBox smsSettingsGroup;
        private System.Windows.Forms.Button smsSettingsSmsModeSetButton;
        private System.Windows.Forms.TextBox smsSettingsSmsServiceCenterTextBox;
        private System.Windows.Forms.Button smsSettingsSmsModeGetButton;
        private System.Windows.Forms.Label smsSettingsSmsServiceCenterLabel;
        private System.Windows.Forms.Label smsSettingsSmsModeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox connectionGroup;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label connectionManufacturerLabel;
        private System.Windows.Forms.Label connectionDeviceModelLabel;
        private System.Windows.Forms.Button saveLogButton;
        private System.Windows.Forms.Button clearLogButton;
    }
}

