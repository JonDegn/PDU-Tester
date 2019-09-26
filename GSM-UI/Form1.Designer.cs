using System;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.commandLabel = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.callBtn = new System.Windows.Forms.Button();
            this.hangupBtn = new System.Windows.Forms.Button();
            this.dialTextBox = new System.Windows.Forms.TextBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.receiveButton = new System.Windows.Forms.Button();
            this.voiceCallTab = new System.Windows.Forms.TabPage();
            this.incomingVoiceCallGroupBox = new System.Windows.Forms.GroupBox();
            this.checkIncomingCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.answerBtn = new System.Windows.Forms.Button();
            this.hangupBtn2 = new System.Windows.Forms.Button();
            this.OutgoingVoiceCallGroupBox = new System.Windows.Forms.GroupBox();
            this.callNumberLabel = new System.Windows.Forms.Label();
            this.smsTab = new System.Windows.Forms.TabPage();
            this.SmsTabControl = new System.Windows.Forms.TabControl();
            this.smsMessageTab = new System.Windows.Forms.TabPage();
            this.smsMessageGroup = new System.Windows.Forms.GroupBox();
            this.smsMessageShowPDUFormatButton = new System.Windows.Forms.Button();
            this.smsMessageLabel = new System.Windows.Forms.Label();
            this.smsMessageSendSmsButton = new System.Windows.Forms.Button();
            this.smsMessageTextBox = new System.Windows.Forms.TextBox();
            this.smsMessagePhoneNumberLabel = new System.Windows.Forms.Label();
            this.smsMessagePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.smsInboxTab = new System.Windows.Forms.TabPage();
            this.smsInboxGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.smsSettingsTab = new System.Windows.Forms.TabPage();
            this.smsSettingsPDUGroup = new System.Windows.Forms.GroupBox();
            this.requestStatusReportCheckBox = new System.Windows.Forms.CheckBox();
            this.dcsComboBox = new System.Windows.Forms.ComboBox();
            this.pidComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.clearLogButton = new System.Windows.Forms.Button();
            this.portConfigurationGroup = new System.Windows.Forms.GroupBox();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.timeoutTextBox = new System.Windows.Forms.TextBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.IncomingCallBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.batteryLevel = new System.Windows.Forms.Label();
            this.batteryLabel = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.voiceCallTab.SuspendLayout();
            this.incomingVoiceCallGroupBox.SuspendLayout();
            this.OutgoingVoiceCallGroupBox.SuspendLayout();
            this.smsTab.SuspendLayout();
            this.SmsTabControl.SuspendLayout();
            this.smsMessageTab.SuspendLayout();
            this.smsMessageGroup.SuspendLayout();
            this.smsInboxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smsInboxGrid)).BeginInit();
            this.smsSettingsTab.SuspendLayout();
            this.smsSettingsPDUGroup.SuspendLayout();
            this.smsSettingsGroup.SuspendLayout();
            this.connectionGroup.SuspendLayout();
            this.portConfigurationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(79, 33);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(100, 20);
            this.cmdTextBox.TabIndex = 0;
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(19, 36);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(54, 13);
            this.commandLabel.TabIndex = 1;
            this.commandLabel.Text = "Command";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(185, 31);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // callBtn
            // 
            this.callBtn.Location = new System.Drawing.Point(70, 71);
            this.callBtn.Name = "callBtn";
            this.callBtn.Size = new System.Drawing.Size(75, 23);
            this.callBtn.TabIndex = 4;
            this.callBtn.Text = "Dial";
            this.callBtn.UseVisualStyleBackColor = true;
            this.callBtn.Click += new System.EventHandler(this.CallBtn_Click);
            // 
            // hangupBtn
            // 
            this.hangupBtn.Location = new System.Drawing.Point(151, 71);
            this.hangupBtn.Name = "hangupBtn";
            this.hangupBtn.Size = new System.Drawing.Size(75, 23);
            this.hangupBtn.TabIndex = 6;
            this.hangupBtn.Text = "Hang Up";
            this.hangupBtn.UseVisualStyleBackColor = true;
            this.hangupBtn.Click += new System.EventHandler(this.HangupBtn_Click);
            // 
            // dialTextBox
            // 
            this.dialTextBox.Location = new System.Drawing.Point(106, 37);
            this.dialTextBox.Name = "dialTextBox";
            this.dialTextBox.Size = new System.Drawing.Size(100, 20);
            this.dialTextBox.TabIndex = 7;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainTab);
            this.mainTabControl.Controls.Add(this.voiceCallTab);
            this.mainTabControl.Controls.Add(this.smsTab);
            this.mainTabControl.Location = new System.Drawing.Point(10, 153);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(499, 380);
            this.mainTabControl.TabIndex = 8;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.receiveButton);
            this.mainTab.Controls.Add(this.commandLabel);
            this.mainTab.Controls.Add(this.cmdTextBox);
            this.mainTab.Controls.Add(this.sendBtn);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(491, 354);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // receiveButton
            // 
            this.receiveButton.Location = new System.Drawing.Point(266, 31);
            this.receiveButton.Name = "receiveButton";
            this.receiveButton.Size = new System.Drawing.Size(75, 23);
            this.receiveButton.TabIndex = 3;
            this.receiveButton.Text = "Receive";
            this.receiveButton.UseVisualStyleBackColor = true;
            this.receiveButton.Click += new System.EventHandler(this.ReceiveButton_Click);
            // 
            // voiceCallTab
            // 
            this.voiceCallTab.Controls.Add(this.incomingVoiceCallGroupBox);
            this.voiceCallTab.Controls.Add(this.OutgoingVoiceCallGroupBox);
            this.voiceCallTab.Location = new System.Drawing.Point(4, 22);
            this.voiceCallTab.Name = "voiceCallTab";
            this.voiceCallTab.Padding = new System.Windows.Forms.Padding(3);
            this.voiceCallTab.Size = new System.Drawing.Size(491, 354);
            this.voiceCallTab.TabIndex = 1;
            this.voiceCallTab.Text = "Voice Call";
            this.voiceCallTab.UseVisualStyleBackColor = true;
            // 
            // incomingVoiceCallGroupBox
            // 
            this.incomingVoiceCallGroupBox.Controls.Add(this.checkIncomingCheckBox);
            this.incomingVoiceCallGroupBox.Controls.Add(this.phoneNumberLabel);
            this.incomingVoiceCallGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.incomingVoiceCallGroupBox.Controls.Add(this.answerBtn);
            this.incomingVoiceCallGroupBox.Controls.Add(this.hangupBtn2);
            this.incomingVoiceCallGroupBox.Location = new System.Drawing.Point(23, 187);
            this.incomingVoiceCallGroupBox.Name = "incomingVoiceCallGroupBox";
            this.incomingVoiceCallGroupBox.Size = new System.Drawing.Size(427, 109);
            this.incomingVoiceCallGroupBox.TabIndex = 9;
            this.incomingVoiceCallGroupBox.TabStop = false;
            this.incomingVoiceCallGroupBox.Text = "Incoming";
            // 
            // checkIncomingCheckBox
            // 
            this.checkIncomingCheckBox.AutoSize = true;
            this.checkIncomingCheckBox.Location = new System.Drawing.Point(263, 39);
            this.checkIncomingCheckBox.Name = "checkIncomingCheckBox";
            this.checkIncomingCheckBox.Size = new System.Drawing.Size(135, 17);
            this.checkIncomingCheckBox.TabIndex = 10;
            this.checkIncomingCheckBox.Text = "Scan for incoming calls";
            this.checkIncomingCheckBox.UseVisualStyleBackColor = true;
            this.checkIncomingCheckBox.CheckedChanged += new System.EventHandler(this.CheckIncomingCheckBox_CheckedChanged);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(22, 40);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Enabled = false;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(106, 37);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.ReadOnly = true;
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 7;
            // 
            // answerBtn
            // 
            this.answerBtn.Location = new System.Drawing.Point(70, 71);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(75, 23);
            this.answerBtn.TabIndex = 5;
            this.answerBtn.Text = "Answer";
            this.answerBtn.UseVisualStyleBackColor = true;
            this.answerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // hangupBtn2
            // 
            this.hangupBtn2.Location = new System.Drawing.Point(151, 71);
            this.hangupBtn2.Name = "hangupBtn2";
            this.hangupBtn2.Size = new System.Drawing.Size(75, 23);
            this.hangupBtn2.TabIndex = 6;
            this.hangupBtn2.Text = "Hang Up";
            this.hangupBtn2.UseVisualStyleBackColor = true;
            this.hangupBtn2.Click += new System.EventHandler(this.HangupBtn_Click);
            // 
            // OutgoingVoiceCallGroupBox
            // 
            this.OutgoingVoiceCallGroupBox.Controls.Add(this.callNumberLabel);
            this.OutgoingVoiceCallGroupBox.Controls.Add(this.dialTextBox);
            this.OutgoingVoiceCallGroupBox.Controls.Add(this.hangupBtn);
            this.OutgoingVoiceCallGroupBox.Controls.Add(this.callBtn);
            this.OutgoingVoiceCallGroupBox.Location = new System.Drawing.Point(23, 54);
            this.OutgoingVoiceCallGroupBox.Name = "OutgoingVoiceCallGroupBox";
            this.OutgoingVoiceCallGroupBox.Size = new System.Drawing.Size(427, 109);
            this.OutgoingVoiceCallGroupBox.TabIndex = 8;
            this.OutgoingVoiceCallGroupBox.TabStop = false;
            this.OutgoingVoiceCallGroupBox.Text = "Outgoing";
            // 
            // callNumberLabel
            // 
            this.callNumberLabel.AutoSize = true;
            this.callNumberLabel.Location = new System.Drawing.Point(22, 40);
            this.callNumberLabel.Name = "callNumberLabel";
            this.callNumberLabel.Size = new System.Drawing.Size(64, 13);
            this.callNumberLabel.TabIndex = 8;
            this.callNumberLabel.Text = "Call Number";
            // 
            // smsTab
            // 
            this.smsTab.Controls.Add(this.SmsTabControl);
            this.smsTab.Location = new System.Drawing.Point(4, 22);
            this.smsTab.Margin = new System.Windows.Forms.Padding(2);
            this.smsTab.Name = "smsTab";
            this.smsTab.Padding = new System.Windows.Forms.Padding(2);
            this.smsTab.Size = new System.Drawing.Size(491, 354);
            this.smsTab.TabIndex = 2;
            this.smsTab.Text = "SMS";
            this.smsTab.UseVisualStyleBackColor = true;
            // 
            // SmsTabControl
            // 
            this.SmsTabControl.Controls.Add(this.smsMessageTab);
            this.SmsTabControl.Controls.Add(this.smsInboxTab);
            this.SmsTabControl.Controls.Add(this.smsSettingsTab);
            this.SmsTabControl.Location = new System.Drawing.Point(3, 29);
            this.SmsTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.SmsTabControl.Name = "SmsTabControl";
            this.SmsTabControl.SelectedIndex = 0;
            this.SmsTabControl.Size = new System.Drawing.Size(485, 324);
            this.SmsTabControl.TabIndex = 0;
            // 
            // smsMessageTab
            // 
            this.smsMessageTab.Controls.Add(this.smsMessageGroup);
            this.smsMessageTab.Location = new System.Drawing.Point(4, 22);
            this.smsMessageTab.Margin = new System.Windows.Forms.Padding(2);
            this.smsMessageTab.Name = "smsMessageTab";
            this.smsMessageTab.Padding = new System.Windows.Forms.Padding(2);
            this.smsMessageTab.Size = new System.Drawing.Size(477, 298);
            this.smsMessageTab.TabIndex = 0;
            this.smsMessageTab.Text = "Message";
            this.smsMessageTab.UseVisualStyleBackColor = true;
            // 
            // smsMessageGroup
            // 
            this.smsMessageGroup.Controls.Add(this.smsMessageShowPDUFormatButton);
            this.smsMessageGroup.Controls.Add(this.smsMessageLabel);
            this.smsMessageGroup.Controls.Add(this.smsMessageSendSmsButton);
            this.smsMessageGroup.Controls.Add(this.smsMessageTextBox);
            this.smsMessageGroup.Controls.Add(this.smsMessagePhoneNumberLabel);
            this.smsMessageGroup.Controls.Add(this.smsMessagePhoneNumberTextBox);
            this.smsMessageGroup.Location = new System.Drawing.Point(10, 12);
            this.smsMessageGroup.Margin = new System.Windows.Forms.Padding(2);
            this.smsMessageGroup.Name = "smsMessageGroup";
            this.smsMessageGroup.Padding = new System.Windows.Forms.Padding(2);
            this.smsMessageGroup.Size = new System.Drawing.Size(452, 157);
            this.smsMessageGroup.TabIndex = 11;
            this.smsMessageGroup.TabStop = false;
            // 
            // smsMessageShowPDUFormatButton
            // 
            this.smsMessageShowPDUFormatButton.Location = new System.Drawing.Point(88, 123);
            this.smsMessageShowPDUFormatButton.Name = "smsMessageShowPDUFormatButton";
            this.smsMessageShowPDUFormatButton.Size = new System.Drawing.Size(111, 23);
            this.smsMessageShowPDUFormatButton.TabIndex = 13;
            this.smsMessageShowPDUFormatButton.Text = "Show PDU Format";
            this.smsMessageShowPDUFormatButton.UseVisualStyleBackColor = true;
            this.smsMessageShowPDUFormatButton.Click += new System.EventHandler(this.SmsMessageShowPDUFormatButton_Click);
            // 
            // smsMessageLabel
            // 
            this.smsMessageLabel.AutoSize = true;
            this.smsMessageLabel.Location = new System.Drawing.Point(4, 47);
            this.smsMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.smsMessageLabel.Name = "smsMessageLabel";
            this.smsMessageLabel.Size = new System.Drawing.Size(50, 13);
            this.smsMessageLabel.TabIndex = 12;
            this.smsMessageLabel.Text = "Message";
            // 
            // smsMessageSendSmsButton
            // 
            this.smsMessageSendSmsButton.Location = new System.Drawing.Point(7, 123);
            this.smsMessageSendSmsButton.Name = "smsMessageSendSmsButton";
            this.smsMessageSendSmsButton.Size = new System.Drawing.Size(75, 23);
            this.smsMessageSendSmsButton.TabIndex = 12;
            this.smsMessageSendSmsButton.Text = "Send SMS";
            this.smsMessageSendSmsButton.UseVisualStyleBackColor = true;
            this.smsMessageSendSmsButton.Click += new System.EventHandler(this.SmsMessageSendSmsButton_Click);
            // 
            // smsMessageTextBox
            // 
            this.smsMessageTextBox.Location = new System.Drawing.Point(7, 61);
            this.smsMessageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.smsMessageTextBox.Multiline = true;
            this.smsMessageTextBox.Name = "smsMessageTextBox";
            this.smsMessageTextBox.Size = new System.Drawing.Size(428, 52);
            this.smsMessageTextBox.TabIndex = 11;
            // 
            // smsMessagePhoneNumberLabel
            // 
            this.smsMessagePhoneNumberLabel.AutoSize = true;
            this.smsMessagePhoneNumberLabel.Location = new System.Drawing.Point(4, 25);
            this.smsMessagePhoneNumberLabel.Name = "smsMessagePhoneNumberLabel";
            this.smsMessagePhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.smsMessagePhoneNumberLabel.TabIndex = 10;
            this.smsMessagePhoneNumberLabel.Text = "Phone Number";
            // 
            // smsMessagePhoneNumberTextBox
            // 
            this.smsMessagePhoneNumberTextBox.Location = new System.Drawing.Point(88, 23);
            this.smsMessagePhoneNumberTextBox.Name = "smsMessagePhoneNumberTextBox";
            this.smsMessagePhoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.smsMessagePhoneNumberTextBox.TabIndex = 9;
            // 
            // smsInboxTab
            // 
            this.smsInboxTab.Controls.Add(this.smsInboxGrid);
            this.smsInboxTab.Controls.Add(this.button1);
            this.smsInboxTab.Location = new System.Drawing.Point(4, 22);
            this.smsInboxTab.Margin = new System.Windows.Forms.Padding(2);
            this.smsInboxTab.Name = "smsInboxTab";
            this.smsInboxTab.Padding = new System.Windows.Forms.Padding(2);
            this.smsInboxTab.Size = new System.Drawing.Size(477, 298);
            this.smsInboxTab.TabIndex = 1;
            this.smsInboxTab.Text = "Inbox";
            this.smsInboxTab.UseVisualStyleBackColor = true;
            // 
            // smsInboxGrid
            // 
            this.smsInboxGrid.AllowUserToAddRows = false;
            this.smsInboxGrid.AllowUserToDeleteRows = false;
            this.smsInboxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.smsInboxGrid.Location = new System.Drawing.Point(8, 5);
            this.smsInboxGrid.Name = "smsInboxGrid";
            this.smsInboxGrid.ReadOnly = true;
            this.smsInboxGrid.Size = new System.Drawing.Size(464, 259);
            this.smsInboxGrid.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Inbox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // smsSettingsTab
            // 
            this.smsSettingsTab.Controls.Add(this.smsSettingsPDUGroup);
            this.smsSettingsTab.Controls.Add(this.smsSettingsGroup);
            this.smsSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.smsSettingsTab.Margin = new System.Windows.Forms.Padding(2);
            this.smsSettingsTab.Name = "smsSettingsTab";
            this.smsSettingsTab.Size = new System.Drawing.Size(477, 298);
            this.smsSettingsTab.TabIndex = 2;
            this.smsSettingsTab.Text = "Settings";
            this.smsSettingsTab.UseVisualStyleBackColor = true;
            // 
            // smsSettingsPDUGroup
            // 
            this.smsSettingsPDUGroup.Controls.Add(this.requestStatusReportCheckBox);
            this.smsSettingsPDUGroup.Controls.Add(this.dcsComboBox);
            this.smsSettingsPDUGroup.Controls.Add(this.pidComboBox);
            this.smsSettingsPDUGroup.Controls.Add(this.label2);
            this.smsSettingsPDUGroup.Controls.Add(this.label1);
            this.smsSettingsPDUGroup.Location = new System.Drawing.Point(22, 129);
            this.smsSettingsPDUGroup.Margin = new System.Windows.Forms.Padding(2);
            this.smsSettingsPDUGroup.Name = "smsSettingsPDUGroup";
            this.smsSettingsPDUGroup.Padding = new System.Windows.Forms.Padding(2);
            this.smsSettingsPDUGroup.Size = new System.Drawing.Size(418, 157);
            this.smsSettingsPDUGroup.TabIndex = 1;
            this.smsSettingsPDUGroup.TabStop = false;
            this.smsSettingsPDUGroup.Text = "PDU Settings";
            // 
            // requestStatusReportCheckBox
            // 
            this.requestStatusReportCheckBox.AutoSize = true;
            this.requestStatusReportCheckBox.Location = new System.Drawing.Point(16, 103);
            this.requestStatusReportCheckBox.Name = "requestStatusReportCheckBox";
            this.requestStatusReportCheckBox.Size = new System.Drawing.Size(127, 17);
            this.requestStatusReportCheckBox.TabIndex = 19;
            this.requestStatusReportCheckBox.Text = "Request status report";
            this.requestStatusReportCheckBox.UseVisualStyleBackColor = true;
            // 
            // dcsComboBox
            // 
            this.dcsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcsComboBox.FormattingEnabled = true;
            this.dcsComboBox.Location = new System.Drawing.Point(171, 55);
            this.dcsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.dcsComboBox.Name = "dcsComboBox";
            this.dcsComboBox.Size = new System.Drawing.Size(189, 21);
            this.dcsComboBox.TabIndex = 18;
            // 
            // pidComboBox
            // 
            this.pidComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pidComboBox.FormattingEnabled = true;
            this.pidComboBox.Location = new System.Drawing.Point(171, 27);
            this.pidComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.pidComboBox.Name = "pidComboBox";
            this.pidComboBox.Size = new System.Drawing.Size(189, 21);
            this.pidComboBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data Coding Scheme (DCS)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Protocol Identifier (PID)";
            // 
            // smsSettingsGroup
            // 
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsModeSetButton);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsServiceCenterTextBox);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsModeGetButton);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsServiceCenterLabel);
            this.smsSettingsGroup.Controls.Add(this.smsSettingsSmsModeLabel);
            this.smsSettingsGroup.Controls.Add(this.comboBox1);
            this.smsSettingsGroup.Location = new System.Drawing.Point(22, 24);
            this.smsSettingsGroup.Margin = new System.Windows.Forms.Padding(2);
            this.smsSettingsGroup.Name = "smsSettingsGroup";
            this.smsSettingsGroup.Padding = new System.Windows.Forms.Padding(2);
            this.smsSettingsGroup.Size = new System.Drawing.Size(418, 89);
            this.smsSettingsGroup.TabIndex = 0;
            this.smsSettingsGroup.TabStop = false;
            // 
            // smsSettingsSmsModeSetButton
            // 
            this.smsSettingsSmsModeSetButton.Location = new System.Drawing.Point(334, 21);
            this.smsSettingsSmsModeSetButton.Name = "smsSettingsSmsModeSetButton";
            this.smsSettingsSmsModeSetButton.Size = new System.Drawing.Size(75, 23);
            this.smsSettingsSmsModeSetButton.TabIndex = 13;
            this.smsSettingsSmsModeSetButton.Text = "Set";
            this.smsSettingsSmsModeSetButton.UseVisualStyleBackColor = true;
            // 
            // smsSettingsSmsServiceCenterTextBox
            // 
            this.smsSettingsSmsServiceCenterTextBox.Location = new System.Drawing.Point(140, 55);
            this.smsSettingsSmsServiceCenterTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.smsSettingsSmsServiceCenterTextBox.Name = "smsSettingsSmsServiceCenterTextBox";
            this.smsSettingsSmsServiceCenterTextBox.Size = new System.Drawing.Size(88, 20);
            this.smsSettingsSmsServiceCenterTextBox.TabIndex = 4;
            // 
            // smsSettingsSmsModeGetButton
            // 
            this.smsSettingsSmsModeGetButton.Location = new System.Drawing.Point(253, 21);
            this.smsSettingsSmsModeGetButton.Name = "smsSettingsSmsModeGetButton";
            this.smsSettingsSmsModeGetButton.Size = new System.Drawing.Size(75, 23);
            this.smsSettingsSmsModeGetButton.TabIndex = 12;
            this.smsSettingsSmsModeGetButton.Text = "Get";
            this.smsSettingsSmsModeGetButton.UseVisualStyleBackColor = true;
            this.smsSettingsSmsModeGetButton.Click += new System.EventHandler(this.SmsSettingsSmsModeGetButton_Click);
            // 
            // smsSettingsSmsServiceCenterLabel
            // 
            this.smsSettingsSmsServiceCenterLabel.AutoSize = true;
            this.smsSettingsSmsServiceCenterLabel.Location = new System.Drawing.Point(12, 56);
            this.smsSettingsSmsServiceCenterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.smsSettingsSmsServiceCenterLabel.Name = "smsSettingsSmsServiceCenterLabel";
            this.smsSettingsSmsServiceCenterLabel.Size = new System.Drawing.Size(103, 13);
            this.smsSettingsSmsServiceCenterLabel.TabIndex = 3;
            this.smsSettingsSmsServiceCenterLabel.Text = "SMS Service Center";
            // 
            // smsSettingsSmsModeLabel
            // 
            this.smsSettingsSmsModeLabel.AutoSize = true;
            this.smsSettingsSmsModeLabel.Location = new System.Drawing.Point(12, 27);
            this.smsSettingsSmsModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.smsSettingsSmsModeLabel.Name = "smsSettingsSmsModeLabel";
            this.smsSettingsSmsModeLabel.Size = new System.Drawing.Size(60, 13);
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
            this.comboBox1.Location = new System.Drawing.Point(140, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dataReceivedRichTextBox
            // 
            this.dataReceivedRichTextBox.Location = new System.Drawing.Point(516, 175);
            this.dataReceivedRichTextBox.Name = "dataReceivedRichTextBox";
            this.dataReceivedRichTextBox.ReadOnly = true;
            this.dataReceivedRichTextBox.Size = new System.Drawing.Size(271, 354);
            this.dataReceivedRichTextBox.TabIndex = 9;
            this.dataReceivedRichTextBox.Text = "";
            // 
            // connectionGroup
            // 
            this.connectionGroup.Controls.Add(this.batteryLevel);
            this.connectionGroup.Controls.Add(this.batteryLabel);
            this.connectionGroup.Controls.Add(this.connectionStatusText);
            this.connectionGroup.Controls.Add(this.connectionManufacturerText);
            this.connectionGroup.Controls.Add(this.connectionDeviceModelText);
            this.connectionGroup.Controls.Add(this.connectionStatusLabel);
            this.connectionGroup.Controls.Add(this.connectionManufacturerLabel);
            this.connectionGroup.Controls.Add(this.connectionDeviceModelLabel);
            this.connectionGroup.Location = new System.Drawing.Point(558, 6);
            this.connectionGroup.Margin = new System.Windows.Forms.Padding(2);
            this.connectionGroup.Name = "connectionGroup";
            this.connectionGroup.Padding = new System.Windows.Forms.Padding(2);
            this.connectionGroup.Size = new System.Drawing.Size(232, 113);
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
            this.connectionStatusText.Location = new System.Drawing.Point(110, 69);
            this.connectionStatusText.Name = "connectionStatusText";
            this.connectionStatusText.Size = new System.Drawing.Size(60, 13);
            this.connectionStatusText.TabIndex = 5;
            this.connectionStatusText.Text = "Unknown";
            // 
            // connectionManufacturerText
            // 
            this.connectionManufacturerText.AutoSize = true;
            this.connectionManufacturerText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectionManufacturerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionManufacturerText.ForeColor = System.Drawing.Color.Blue;
            this.connectionManufacturerText.Location = new System.Drawing.Point(110, 49);
            this.connectionManufacturerText.Name = "connectionManufacturerText";
            this.connectionManufacturerText.Size = new System.Drawing.Size(60, 13);
            this.connectionManufacturerText.TabIndex = 4;
            this.connectionManufacturerText.Text = "Unknown";
            // 
            // connectionDeviceModelText
            // 
            this.connectionDeviceModelText.AutoSize = true;
            this.connectionDeviceModelText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectionDeviceModelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionDeviceModelText.ForeColor = System.Drawing.Color.Blue;
            this.connectionDeviceModelText.Location = new System.Drawing.Point(110, 28);
            this.connectionDeviceModelText.Name = "connectionDeviceModelText";
            this.connectionDeviceModelText.Size = new System.Drawing.Size(60, 13);
            this.connectionDeviceModelText.TabIndex = 3;
            this.connectionDeviceModelText.Text = "Unknown";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(10, 69);
            this.connectionStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(37, 13);
            this.connectionStatusLabel.TabIndex = 2;
            this.connectionStatusLabel.Text = "Status";
            // 
            // connectionManufacturerLabel
            // 
            this.connectionManufacturerLabel.AutoSize = true;
            this.connectionManufacturerLabel.Location = new System.Drawing.Point(10, 49);
            this.connectionManufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectionManufacturerLabel.Name = "connectionManufacturerLabel";
            this.connectionManufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.connectionManufacturerLabel.TabIndex = 1;
            this.connectionManufacturerLabel.Text = "Manufacturer";
            // 
            // connectionDeviceModelLabel
            // 
            this.connectionDeviceModelLabel.AutoSize = true;
            this.connectionDeviceModelLabel.Location = new System.Drawing.Point(10, 28);
            this.connectionDeviceModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectionDeviceModelLabel.Name = "connectionDeviceModelLabel";
            this.connectionDeviceModelLabel.Size = new System.Drawing.Size(73, 13);
            this.connectionDeviceModelLabel.TabIndex = 0;
            this.connectionDeviceModelLabel.Text = "Device Model";
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(712, 146);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogButton.TabIndex = 10;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // portConfigurationGroup
            // 
            this.portConfigurationGroup.Controls.Add(this.timeoutLabel);
            this.portConfigurationGroup.Controls.Add(this.timeoutTextBox);
            this.portConfigurationGroup.Controls.Add(this.baudRateLabel);
            this.portConfigurationGroup.Controls.Add(this.portLabel);
            this.portConfigurationGroup.Controls.Add(this.connectBtn);
            this.portConfigurationGroup.Controls.Add(this.baudRateComboBox);
            this.portConfigurationGroup.Controls.Add(this.portComboBox);
            this.portConfigurationGroup.Location = new System.Drawing.Point(10, 12);
            this.portConfigurationGroup.Name = "portConfigurationGroup";
            this.portConfigurationGroup.Size = new System.Drawing.Size(495, 122);
            this.portConfigurationGroup.TabIndex = 13;
            this.portConfigurationGroup.TabStop = false;
            this.portConfigurationGroup.Text = "Port Configuration";
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Location = new System.Drawing.Point(16, 90);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(67, 13);
            this.timeoutLabel.TabIndex = 6;
            this.timeoutLabel.Text = "Timeout (ms)";
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.Location = new System.Drawing.Point(94, 87);
            this.timeoutTextBox.Name = "timeoutTextBox";
            this.timeoutTextBox.Size = new System.Drawing.Size(49, 20);
            this.timeoutTextBox.TabIndex = 5;
            this.timeoutTextBox.Text = "500";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(16, 63);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(58, 13);
            this.baudRateLabel.TabIndex = 4;
            this.baudRateLabel.Text = "Baud Rate";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(16, 35);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port";
            this.portLabel.Click += new System.EventHandler(this.PortLabel_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(392, 33);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
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
            this.baudRateComboBox.Location = new System.Drawing.Point(94, 60);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(69, 21);
            this.baudRateComboBox.TabIndex = 1;
            // 
            // portComboBox
            // 
            this.portComboBox.DisplayMember = "desc";
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(94, 35);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(232, 21);
            this.portComboBox.TabIndex = 0;
            this.portComboBox.ValueMember = "name";
            // 
            // IncomingCallBackgroundWorker
            // 
            this.IncomingCallBackgroundWorker.WorkerSupportsCancellation = true;
            this.IncomingCallBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // batteryLevel
            // 
            this.batteryLevel.AutoSize = true;
            this.batteryLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.batteryLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryLevel.ForeColor = System.Drawing.Color.Blue;
            this.batteryLevel.Location = new System.Drawing.Point(110, 89);
            this.batteryLevel.Name = "batteryLevel";
            this.batteryLevel.Size = new System.Drawing.Size(60, 13);
            this.batteryLevel.TabIndex = 7;
            this.batteryLevel.Text = "Unknown";
            // 
            // batteryLabel
            // 
            this.batteryLabel.AutoSize = true;
            this.batteryLabel.Location = new System.Drawing.Point(10, 89);
            this.batteryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.batteryLabel.Name = "batteryLabel";
            this.batteryLabel.Size = new System.Drawing.Size(40, 13);
            this.batteryLabel.TabIndex = 6;
            this.batteryLabel.Text = "Battery";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.portConfigurationGroup);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.connectionGroup);
            this.Controls.Add(this.dataReceivedRichTextBox);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.smsInboxTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smsInboxGrid)).EndInit();
            this.smsSettingsTab.ResumeLayout(false);
            this.smsSettingsPDUGroup.ResumeLayout(false);
            this.smsSettingsPDUGroup.PerformLayout();
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
        private System.Windows.Forms.TabPage smsTab;
        private System.Windows.Forms.TabControl SmsTabControl;
        private System.Windows.Forms.TabPage smsMessageTab;
        private System.Windows.Forms.GroupBox smsMessageGroup;
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
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.Label connectionStatusText;
        private System.Windows.Forms.Label connectionManufacturerText;
        private System.Windows.Forms.Label connectionDeviceModelText;
        private System.Windows.Forms.GroupBox portConfigurationGroup;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label timeoutLabel;
        private System.Windows.Forms.TextBox timeoutTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dcsComboBox;
        private System.Windows.Forms.ComboBox pidComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView smsInboxGrid;
        private System.Windows.Forms.Button receiveButton;
        private System.ComponentModel.BackgroundWorker IncomingCallBackgroundWorker;
        private System.Windows.Forms.CheckBox checkIncomingCheckBox;
        private System.Windows.Forms.CheckBox requestStatusReportCheckBox;
        private System.Windows.Forms.Label batteryLevel;
        private System.Windows.Forms.Label batteryLabel;
    }
}

