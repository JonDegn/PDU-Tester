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
            this.commandLabel = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.callBtn = new System.Windows.Forms.Button();
            this.hangupBtn = new System.Windows.Forms.Button();
            this.dialTextBox = new System.Windows.Forms.TextBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.voiceCallTab = new System.Windows.Forms.TabPage();
            this.incomingVoiceCallGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.answerBtn = new System.Windows.Forms.Button();
            this.hangupBtn2 = new System.Windows.Forms.Button();
            this.OutgoingVoiceCallGroupBox = new System.Windows.Forms.GroupBox();
            this.redialButton = new System.Windows.Forms.Button();
            this.callNumberLabel = new System.Windows.Forms.Label();
            this.smsTab = new System.Windows.Forms.TabPage();
            this.SmsTabControl = new System.Windows.Forms.TabControl();
            this.smsMessageTab = new System.Windows.Forms.TabPage();
            this.smsMessageGroup = new System.Windows.Forms.GroupBox();
            this.smsMessageShowTextFormatButton = new System.Windows.Forms.Button();
            this.smsMessageShowPDUFormatButton = new System.Windows.Forms.Button();
            this.smsMessageLabel = new System.Windows.Forms.Label();
            this.smsMessageSendSmsButton = new System.Windows.Forms.Button();
            this.smsMessageTextBox = new System.Windows.Forms.TextBox();
            this.smsMessagePhoneNumberLabel = new System.Windows.Forms.Label();
            this.smsMessagePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.smsInboxTab = new System.Windows.Forms.TabPage();
            this.smsSettingsTab = new System.Windows.Forms.TabPage();
            this.smsSettingsPDUGroup = new System.Windows.Forms.GroupBox();
            this.smsSettingsGroup = new System.Windows.Forms.GroupBox();
            this.smsSettingsSmsModeSetButton = new System.Windows.Forms.Button();
            this.smsSettingsSmsServiceCenterTextBox = new System.Windows.Forms.TextBox();
            this.smsSettingsSmsModeGetButton = new System.Windows.Forms.Button();
            this.smsSettingsSmsServiceCenterLabel = new System.Windows.Forms.Label();
            this.smsSettingsSmsModeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataReceivedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.connectionGroup = new System.Windows.Forms.GroupBox();
            this.connectionStatusText = new System.Windows.Forms.Label();
            this.connectionManufacturerText = new System.Windows.Forms.Label();
            this.connectionDeviceModelText = new System.Windows.Forms.Label();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.connectionManufacturerLabel = new System.Windows.Forms.Label();
            this.connectionDeviceModelLabel = new System.Windows.Forms.Label();
            this.saveLogButton = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.portConfigurationGroup = new System.Windows.Forms.GroupBox();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.findPortsBtn = new System.Windows.Forms.Button();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.timeoutTextBox = new System.Windows.Forms.TextBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.mainTabControl.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.voiceCallTab.SuspendLayout();
            this.incomingVoiceCallGroupBox.SuspendLayout();
            this.OutgoingVoiceCallGroupBox.SuspendLayout();
            this.smsTab.SuspendLayout();
            this.SmsTabControl.SuspendLayout();
            this.smsMessageTab.SuspendLayout();
            this.smsMessageGroup.SuspendLayout();
            this.smsSettingsTab.SuspendLayout();
            this.smsSettingsGroup.SuspendLayout();
            this.connectionGroup.SuspendLayout();
            this.portConfigurationGroup.SuspendLayout();
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
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(38, 69);
            this.commandLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(109, 25);
            this.commandLabel.TabIndex = 1;
            this.commandLabel.Text = "Command";
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
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainTab);
            this.mainTabControl.Controls.Add(this.voiceCallTab);
            this.mainTabControl.Controls.Add(this.smsTab);
            this.mainTabControl.Location = new System.Drawing.Point(20, 294);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(998, 731);
            this.mainTabControl.TabIndex = 8;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.commandLabel);
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
            this.incomingVoiceCallGroupBox.Controls.Add(this.hangupBtn2);
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
            // hangupBtn2
            // 
            this.hangupBtn2.Location = new System.Drawing.Point(302, 137);
            this.hangupBtn2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hangupBtn2.Name = "hangupBtn2";
            this.hangupBtn2.Size = new System.Drawing.Size(150, 44);
            this.hangupBtn2.TabIndex = 6;
            this.hangupBtn2.Text = "Hang Up";
            this.hangupBtn2.UseVisualStyleBackColor = true;
            this.hangupBtn2.Click += new System.EventHandler(this.HangupBtn_Click);
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
            // smsTab
            // 
            this.smsTab.Controls.Add(this.SmsTabControl);
            this.smsTab.Location = new System.Drawing.Point(8, 39);
            this.smsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsTab.Name = "smsTab";
            this.smsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsTab.Size = new System.Drawing.Size(982, 684);
            this.smsTab.TabIndex = 2;
            this.smsTab.Text = "SMS";
            this.smsTab.UseVisualStyleBackColor = true;
            // 
            // SmsTabControl
            // 
            this.SmsTabControl.Controls.Add(this.smsMessageTab);
            this.SmsTabControl.Controls.Add(this.smsInboxTab);
            this.SmsTabControl.Controls.Add(this.smsSettingsTab);
            this.SmsTabControl.Location = new System.Drawing.Point(6, 56);
            this.SmsTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SmsTabControl.Name = "SmsTabControl";
            this.SmsTabControl.SelectedIndex = 0;
            this.SmsTabControl.Size = new System.Drawing.Size(970, 623);
            this.SmsTabControl.TabIndex = 0;
            // 
            // smsMessageTab
            // 
            this.smsMessageTab.Controls.Add(this.smsMessageGroup);
            this.smsMessageTab.Location = new System.Drawing.Point(8, 39);
            this.smsMessageTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsMessageTab.Name = "smsMessageTab";
            this.smsMessageTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsMessageTab.Size = new System.Drawing.Size(954, 576);
            this.smsMessageTab.TabIndex = 0;
            this.smsMessageTab.Text = "Message";
            this.smsMessageTab.UseVisualStyleBackColor = true;
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
            this.smsMessageGroup.Location = new System.Drawing.Point(20, 23);
            this.smsMessageGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsMessageGroup.Name = "smsMessageGroup";
            this.smsMessageGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsMessageGroup.Size = new System.Drawing.Size(904, 302);
            this.smsMessageGroup.TabIndex = 11;
            this.smsMessageGroup.TabStop = false;
            // 
            // smsMessageShowTextFormatButton
            // 
            this.smsMessageShowTextFormatButton.Location = new System.Drawing.Point(410, 237);
            this.smsMessageShowTextFormatButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.smsMessageShowTextFormatButton.Name = "smsMessageShowTextFormatButton";
            this.smsMessageShowTextFormatButton.Size = new System.Drawing.Size(224, 44);
            this.smsMessageShowTextFormatButton.TabIndex = 14;
            this.smsMessageShowTextFormatButton.Text = "Show Text Format";
            this.smsMessageShowTextFormatButton.UseVisualStyleBackColor = true;
            // 
            // smsMessageShowPDUFormatButton
            // 
            this.smsMessageShowPDUFormatButton.Location = new System.Drawing.Point(176, 237);
            this.smsMessageShowPDUFormatButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.smsMessageShowPDUFormatButton.Name = "smsMessageShowPDUFormatButton";
            this.smsMessageShowPDUFormatButton.Size = new System.Drawing.Size(222, 44);
            this.smsMessageShowPDUFormatButton.TabIndex = 13;
            this.smsMessageShowPDUFormatButton.Text = "Show PDU Format";
            this.smsMessageShowPDUFormatButton.UseVisualStyleBackColor = true;
            // 
            // smsMessageLabel
            // 
            this.smsMessageLabel.AutoSize = true;
            this.smsMessageLabel.Location = new System.Drawing.Point(8, 90);
            this.smsMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smsMessageLabel.Name = "smsMessageLabel";
            this.smsMessageLabel.Size = new System.Drawing.Size(100, 25);
            this.smsMessageLabel.TabIndex = 12;
            this.smsMessageLabel.Text = "Message";
            // 
            // smsMessageSendSmsButton
            // 
            this.smsMessageSendSmsButton.Location = new System.Drawing.Point(14, 237);
            this.smsMessageSendSmsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.smsMessageSendSmsButton.Name = "smsMessageSendSmsButton";
            this.smsMessageSendSmsButton.Size = new System.Drawing.Size(150, 44);
            this.smsMessageSendSmsButton.TabIndex = 12;
            this.smsMessageSendSmsButton.Text = "Send SMS";
            this.smsMessageSendSmsButton.UseVisualStyleBackColor = true;
            // 
            // smsMessageTextBox
            // 
            this.smsMessageTextBox.Location = new System.Drawing.Point(14, 117);
            this.smsMessageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsMessageTextBox.Multiline = true;
            this.smsMessageTextBox.Name = "smsMessageTextBox";
            this.smsMessageTextBox.Size = new System.Drawing.Size(852, 96);
            this.smsMessageTextBox.TabIndex = 11;
            // 
            // smsMessagePhoneNumberLabel
            // 
            this.smsMessagePhoneNumberLabel.AutoSize = true;
            this.smsMessagePhoneNumberLabel.Location = new System.Drawing.Point(8, 48);
            this.smsMessagePhoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.smsMessagePhoneNumberLabel.Name = "smsMessagePhoneNumberLabel";
            this.smsMessagePhoneNumberLabel.Size = new System.Drawing.Size(155, 25);
            this.smsMessagePhoneNumberLabel.TabIndex = 10;
            this.smsMessagePhoneNumberLabel.Text = "Phone Number";
            // 
            // smsMessagePhoneNumberTextBox
            // 
            this.smsMessagePhoneNumberTextBox.Location = new System.Drawing.Point(176, 44);
            this.smsMessagePhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.smsMessagePhoneNumberTextBox.Name = "smsMessagePhoneNumberTextBox";
            this.smsMessagePhoneNumberTextBox.Size = new System.Drawing.Size(196, 31);
            this.smsMessagePhoneNumberTextBox.TabIndex = 9;
            // 
            // smsInboxTab
            // 
            this.smsInboxTab.Location = new System.Drawing.Point(8, 39);
            this.smsInboxTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsInboxTab.Name = "smsInboxTab";
            this.smsInboxTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsInboxTab.Size = new System.Drawing.Size(954, 576);
            this.smsInboxTab.TabIndex = 1;
            this.smsInboxTab.Text = "Inbox";
            this.smsInboxTab.UseVisualStyleBackColor = true;
            // 
            // smsSettingsTab
            // 
            this.smsSettingsTab.Controls.Add(this.smsSettingsPDUGroup);
            this.smsSettingsTab.Controls.Add(this.smsSettingsGroup);
            this.smsSettingsTab.Location = new System.Drawing.Point(8, 39);
            this.smsSettingsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsSettingsTab.Name = "smsSettingsTab";
            this.smsSettingsTab.Size = new System.Drawing.Size(954, 576);
            this.smsSettingsTab.TabIndex = 2;
            this.smsSettingsTab.Text = "Settings";
            this.smsSettingsTab.UseVisualStyleBackColor = true;
            // 
            // smsSettingsPDUGroup
            // 
            this.smsSettingsPDUGroup.Location = new System.Drawing.Point(44, 248);
            this.smsSettingsPDUGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsSettingsPDUGroup.Name = "smsSettingsPDUGroup";
            this.smsSettingsPDUGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsSettingsPDUGroup.Size = new System.Drawing.Size(836, 302);
            this.smsSettingsPDUGroup.TabIndex = 1;
            this.smsSettingsPDUGroup.TabStop = false;
            this.smsSettingsPDUGroup.Text = "PDU Settings";
            // 
            // smsSettingsGroup
            // 
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsModeSetButton);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsServiceCenterTextBox);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsModeGetButton);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsServiceCenterLabel);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsModeLabel);
            this.smsSettingsGroup.Controls.Add(this.comboBox1);
            this.smsSettingsGroup.Location = new System.Drawing.Point(44, 46);
            this.smsSettingsGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsSettingsGroup.Name = "smsSettingsGroup";
            this.smsSettingsGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsSettingsGroup.Size = new System.Drawing.Size(836, 171);
            this.smsSettingsGroup.TabIndex = 0;
            this.smsSettingsGroup.TabStop = false;
            // 
            // smsSettingsSmsModeSetButton
            // 
            this.smsSettingsSmsModeSetButton.Location = new System.Drawing.Point(668, 40);
            this.smsSettingsSmsModeSetButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.smsSettingsSmsModeSetButton.Name = "smsSettingsSmsModeSetButton";
            this.smsSettingsSmsModeSetButton.Size = new System.Drawing.Size(150, 44);
            this.smsSettingsSmsModeSetButton.TabIndex = 13;
            this.smsSettingsSmsModeSetButton.Text = "Set";
            this.smsSettingsSmsModeSetButton.UseVisualStyleBackColor = true;
            // 
            // smsSettingsSmsServiceCenterTextBox
            // 
            this.smsSettingsSmsServiceCenterTextBox.Location = new System.Drawing.Point(280, 106);
            this.smsSettingsSmsServiceCenterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smsSettingsSmsServiceCenterTextBox.Name = "smsSettingsSmsServiceCenterTextBox";
            this.smsSettingsSmsServiceCenterTextBox.Size = new System.Drawing.Size(172, 31);
            this.smsSettingsSmsServiceCenterTextBox.TabIndex = 4;
            // 
            // smsSettingsSmsModeGetButton
            // 
            this.smsSettingsSmsModeGetButton.Location = new System.Drawing.Point(506, 40);
            this.smsSettingsSmsModeGetButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.smsSettingsSmsModeGetButton.Name = "smsSettingsSmsModeGetButton";
            this.smsSettingsSmsModeGetButton.Size = new System.Drawing.Size(150, 44);
            this.smsSettingsSmsModeGetButton.TabIndex = 12;
            this.smsSettingsSmsModeGetButton.Text = "Get";
            this.smsSettingsSmsModeGetButton.UseVisualStyleBackColor = true;
            // 
            // smsSettingsSmsServiceCenterLabel
            // 
            this.smsSettingsSmsServiceCenterLabel.AutoSize = true;
            this.smsSettingsSmsServiceCenterLabel.Location = new System.Drawing.Point(24, 108);
            this.smsSettingsSmsServiceCenterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smsSettingsSmsServiceCenterLabel.Name = "smsSettingsSmsServiceCenterLabel";
            this.smsSettingsSmsServiceCenterLabel.Size = new System.Drawing.Size(206, 25);
            this.smsSettingsSmsServiceCenterLabel.TabIndex = 3;
            this.smsSettingsSmsServiceCenterLabel.Text = "SMS Service Center";
            // 
            // smsSettingsSmsModeLabel
            // 
            this.smsSettingsSmsModeLabel.AutoSize = true;
            this.smsSettingsSmsModeLabel.Location = new System.Drawing.Point(24, 52);
            this.smsSettingsSmsModeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smsSettingsSmsModeLabel.Name = "smsSettingsSmsModeLabel";
            this.smsSettingsSmsModeLabel.Size = new System.Drawing.Size(118, 25);
            this.smsSettingsSmsModeLabel.TabIndex = 2;
            this.smsSettingsSmsModeLabel.Text = "SMS Mode";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Text",
            "PDU"});
            this.comboBox1.Location = new System.Drawing.Point(280, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // dataReceivedRichTextBox
            // 
            this.dataReceivedRichTextBox.Location = new System.Drawing.Point(1032, 337);
            this.dataReceivedRichTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataReceivedRichTextBox.Name = "dataReceivedRichTextBox";
            this.dataReceivedRichTextBox.ReadOnly = true;
            this.dataReceivedRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.dataReceivedRichTextBox.Size = new System.Drawing.Size(538, 677);
            this.dataReceivedRichTextBox.TabIndex = 9;
            this.dataReceivedRichTextBox.Text = "";
            // 
            // connectionGroup
            // 
            this.connectionGroup.Controls.Add(this.connectionStatusText);
            this.connectionGroup.Controls.Add(this.connectionManufacturerText);
            this.connectionGroup.Controls.Add(this.connectionDeviceModelText);
            this.connectionGroup.Controls.Add(this.connectionStatusLabel);
            this.connectionGroup.Controls.Add(this.connectionManufacturerLabel);
            this.connectionGroup.Controls.Add(this.connectionDeviceModelLabel);
            this.connectionGroup.Location = new System.Drawing.Point(1116, 12);
            this.connectionGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionGroup.Name = "connectionGroup";
            this.connectionGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionGroup.Size = new System.Drawing.Size(464, 192);
            this.connectionGroup.TabIndex = 10;
            this.connectionGroup.TabStop = false;
            this.connectionGroup.Text = "Connection";
            // 
            // connectionStatusText
            // 
            this.connectionStatusText.AutoSize = true;
            this.connectionStatusText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectionStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionStatusText.ForeColor = System.Drawing.Color.Blue;
            this.connectionStatusText.Location = new System.Drawing.Point(220, 133);
            this.connectionStatusText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.connectionStatusText.Name = "connectionStatusText";
            this.connectionStatusText.Size = new System.Drawing.Size(110, 26);
            this.connectionStatusText.TabIndex = 5;
            this.connectionStatusText.Text = "Unknown";
            // 
            // connectionManufacturerText
            // 
            this.connectionManufacturerText.AutoSize = true;
            this.connectionManufacturerText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectionManufacturerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionManufacturerText.ForeColor = System.Drawing.Color.Blue;
            this.connectionManufacturerText.Location = new System.Drawing.Point(220, 94);
            this.connectionManufacturerText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.connectionManufacturerText.Name = "connectionManufacturerText";
            this.connectionManufacturerText.Size = new System.Drawing.Size(110, 26);
            this.connectionManufacturerText.TabIndex = 4;
            this.connectionManufacturerText.Text = "Unknown";
            // 
            // connectionDeviceModelText
            // 
            this.connectionDeviceModelText.AutoSize = true;
            this.connectionDeviceModelText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectionDeviceModelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionDeviceModelText.ForeColor = System.Drawing.Color.Blue;
            this.connectionDeviceModelText.Location = new System.Drawing.Point(220, 54);
            this.connectionDeviceModelText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.connectionDeviceModelText.Name = "connectionDeviceModelText";
            this.connectionDeviceModelText.Size = new System.Drawing.Size(110, 26);
            this.connectionDeviceModelText.TabIndex = 3;
            this.connectionDeviceModelText.Text = "Unknown";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(20, 133);
            this.connectionStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(73, 25);
            this.connectionStatusLabel.TabIndex = 2;
            this.connectionStatusLabel.Text = "Status";
            // 
            // connectionManufacturerLabel
            // 
            this.connectionManufacturerLabel.AutoSize = true;
            this.connectionManufacturerLabel.Location = new System.Drawing.Point(20, 94);
            this.connectionManufacturerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionManufacturerLabel.Name = "connectionManufacturerLabel";
            this.connectionManufacturerLabel.Size = new System.Drawing.Size(139, 25);
            this.connectionManufacturerLabel.TabIndex = 1;
            this.connectionManufacturerLabel.Text = "Manufacturer";
            // 
            // connectionDeviceModelLabel
            // 
            this.connectionDeviceModelLabel.AutoSize = true;
            this.connectionDeviceModelLabel.Location = new System.Drawing.Point(20, 54);
            this.connectionDeviceModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionDeviceModelLabel.Name = "connectionDeviceModelLabel";
            this.connectionDeviceModelLabel.Size = new System.Drawing.Size(143, 25);
            this.connectionDeviceModelLabel.TabIndex = 0;
            this.connectionDeviceModelLabel.Text = "Device Model";
            // 
            // saveLogButton
            // 
            this.saveLogButton.Location = new System.Drawing.Point(1420, 281);
            this.saveLogButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.saveLogButton.Name = "saveLogButton";
            this.saveLogButton.Size = new System.Drawing.Size(150, 44);
            this.saveLogButton.TabIndex = 11;
            this.saveLogButton.Text = "Save Log";
            this.saveLogButton.UseVisualStyleBackColor = true;
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(1256, 281);
            this.clearLogButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(150, 44);
            this.clearLogButton.TabIndex = 10;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            // 
            // getInfoButton
            // 
            this.getInfoButton.Location = new System.Drawing.Point(1116, 213);
            this.getInfoButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(150, 44);
            this.getInfoButton.TabIndex = 12;
            this.getInfoButton.Text = "Get Info";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.GetInfoButton_Click);
            // 
            // portConfigurationGroup
            // 
            this.portConfigurationGroup.Controls.Add(this.disconnectBtn);
            this.portConfigurationGroup.Controls.Add(this.findPortsBtn);
            this.portConfigurationGroup.Controls.Add(this.timeoutLabel);
            this.portConfigurationGroup.Controls.Add(this.timeoutTextBox);
            this.portConfigurationGroup.Controls.Add(this.baudRateLabel);
            this.portConfigurationGroup.Controls.Add(this.portLabel);
            this.portConfigurationGroup.Controls.Add(this.connectBtn);
            this.portConfigurationGroup.Controls.Add(this.baudRateComboBox);
            this.portConfigurationGroup.Controls.Add(this.portComboBox);
            this.portConfigurationGroup.Location = new System.Drawing.Point(20, 23);
            this.portConfigurationGroup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.portConfigurationGroup.Name = "portConfigurationGroup";
            this.portConfigurationGroup.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.portConfigurationGroup.Size = new System.Drawing.Size(990, 235);
            this.portConfigurationGroup.TabIndex = 13;
            this.portConfigurationGroup.TabStop = false;
            this.portConfigurationGroup.Text = "Port Configuration";
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(408, 137);
            this.disconnectBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(150, 44);
            this.disconnectBtn.TabIndex = 8;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // findPortsBtn
            // 
            this.findPortsBtn.Location = new System.Drawing.Point(38, 137);
            this.findPortsBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.findPortsBtn.Name = "findPortsBtn";
            this.findPortsBtn.Size = new System.Drawing.Size(150, 44);
            this.findPortsBtn.TabIndex = 7;
            this.findPortsBtn.Text = "Find Ports";
            this.findPortsBtn.UseVisualStyleBackColor = true;
            this.findPortsBtn.Click += new System.EventHandler(this.FindPortsBtn_Click);
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Location = new System.Drawing.Point(620, 67);
            this.timeoutLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(137, 25);
            this.timeoutLabel.TabIndex = 6;
            this.timeoutLabel.Text = "Timeout (ms)";
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.Location = new System.Drawing.Point(766, 62);
            this.timeoutTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.timeoutTextBox.Name = "timeoutTextBox";
            this.timeoutTextBox.Size = new System.Drawing.Size(94, 31);
            this.timeoutTextBox.TabIndex = 5;
            this.timeoutTextBox.Text = "500";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(280, 67);
            this.baudRateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(113, 25);
            this.baudRateLabel.TabIndex = 4;
            this.baudRateLabel.Text = "Baud Rate";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(32, 67);
            this.portLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(51, 25);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(216, 137);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(150, 44);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRateComboBox.Location = new System.Drawing.Point(408, 62);
            this.baudRateComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(170, 33);
            this.baudRateComboBox.TabIndex = 1;
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(96, 62);
            this.portComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(132, 33);
            this.portComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1040);
            this.Controls.Add(this.portConfigurationGroup);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.saveLogButton);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.connectionGroup);
            this.Controls.Add(this.dataReceivedRichTextBox);
            this.Controls.Add(this.mainTabControl);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "GSM Tester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.voiceCallTab.ResumeLayout(false);
            this.incomingVoiceCallGroupBox.ResumeLayout(false);
            this.incomingVoiceCallGroupBox.PerformLayout();
            this.OutgoingVoiceCallGroupBox.ResumeLayout(false);
            this.OutgoingVoiceCallGroupBox.PerformLayout();
            this.smsTab.ResumeLayout(false);
            this.SmsTabControl.ResumeLayout(false);
            this.smsMessageTab.ResumeLayout(false);
            this.smsMessageGroup.ResumeLayout(false);
            this.smsMessageGroup.PerformLayout();
            this.smsSettingsTab.ResumeLayout(false);
            this.smsSettingsGroup.ResumeLayout(false);
            this.smsSettingsGroup.PerformLayout();
            this.connectionGroup.ResumeLayout(false);
            this.connectionGroup.PerformLayout();
            this.portConfigurationGroup.ResumeLayout(false);
            this.portConfigurationGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button callBtn;
        private System.Windows.Forms.Button hangupBtn;
        private System.Windows.Forms.TextBox dialTextBox;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage voiceCallTab;
        private System.Windows.Forms.GroupBox incomingVoiceCallGroupBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button answerBtn;
        private System.Windows.Forms.Button hangupBtn2;
        private System.Windows.Forms.GroupBox OutgoingVoiceCallGroupBox;
        private System.Windows.Forms.Label callNumberLabel;
        private System.Windows.Forms.RichTextBox dataReceivedRichTextBox;
        private System.Windows.Forms.Button redialButton;
        private System.Windows.Forms.TabPage smsTab;
        private System.Windows.Forms.TabControl SmsTabControl;
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
        private System.Windows.Forms.Label connectionStatusText;
        private System.Windows.Forms.Label connectionManufacturerText;
        private System.Windows.Forms.Label connectionDeviceModelText;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.GroupBox portConfigurationGroup;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label timeoutLabel;
        private System.Windows.Forms.TextBox timeoutTextBox;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button findPortsBtn;
    }
}

