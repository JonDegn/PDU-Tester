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
            this.connectionGroup = new System.Windows.Forms.GroupBox();
            this.batteryLevel = new System.Windows.Forms.Label();
            this.batteryLabel = new System.Windows.Forms.Label();
            this.connectionStatusText = new System.Windows.Forms.Label();
            this.connectionManufacturerText = new System.Windows.Forms.Label();
            this.connectionDeviceModelText = new System.Windows.Forms.Label();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.connectionManufacturerLabel = new System.Windows.Forms.Label();
            this.connectionDeviceModelLabel = new System.Windows.Forms.Label();
            this.portConfigurationGroup = new System.Windows.Forms.GroupBox();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.timeoutTextBox = new System.Windows.Forms.TextBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataReceivedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.commandLabel = new System.Windows.Forms.Label();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.smsTab = new System.Windows.Forms.TabPage();
            this.SmsTabControl = new System.Windows.Forms.TabControl();
            this.smsMessageTab = new System.Windows.Forms.TabPage();
            this.smsMessageLabel = new System.Windows.Forms.Label();
            this.pduLengthLabel = new System.Windows.Forms.Label();
            this.pduTextBox = new System.Windows.Forms.TextBox();
            this.smsMessageSendSmsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.smsMessageTextBox = new System.Windows.Forms.TextBox();
            this.smsSettingsPDUGroup = new System.Windows.Forms.GroupBox();
            this.requestStatusReportCheckBox = new System.Windows.Forms.CheckBox();
            this.dcsComboBox = new System.Windows.Forms.ComboBox();
            this.pidComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.smsMessagePhoneNumberLabel = new System.Windows.Forms.Label();
            this.smsMessagePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.smsInboxTab = new System.Windows.Forms.TabPage();
            this.smsInboxGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.connectionGroup.SuspendLayout();
            this.portConfigurationGroup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.smsTab.SuspendLayout();
            this.SmsTabControl.SuspendLayout();
            this.smsMessageTab.SuspendLayout();
            this.smsSettingsPDUGroup.SuspendLayout();
            this.smsInboxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smsInboxGrid)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
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
            this.connectionGroup.Location = new System.Drawing.Point(1123, 23);
            this.connectionGroup.Margin = new System.Windows.Forms.Padding(4);
            this.connectionGroup.Name = "connectionGroup";
            this.connectionGroup.Padding = new System.Windows.Forms.Padding(4);
            this.connectionGroup.Size = new System.Drawing.Size(464, 235);
            this.connectionGroup.TabIndex = 10;
            this.connectionGroup.TabStop = false;
            this.connectionGroup.Text = "Connection";
            // 
            // batteryLevel
            // 
            this.batteryLevel.AutoSize = true;
            this.batteryLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.batteryLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryLevel.ForeColor = System.Drawing.Color.Blue;
            this.batteryLevel.Location = new System.Drawing.Point(220, 171);
            this.batteryLevel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.batteryLevel.Name = "batteryLevel";
            this.batteryLevel.Size = new System.Drawing.Size(110, 26);
            this.batteryLevel.TabIndex = 7;
            this.batteryLevel.Text = "Unknown";
            // 
            // batteryLabel
            // 
            this.batteryLabel.AutoSize = true;
            this.batteryLabel.Location = new System.Drawing.Point(20, 171);
            this.batteryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.batteryLabel.Name = "batteryLabel";
            this.batteryLabel.Size = new System.Drawing.Size(80, 25);
            this.batteryLabel.TabIndex = 6;
            this.batteryLabel.Text = "Battery";
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
            // portConfigurationGroup
            // 
            this.portConfigurationGroup.Controls.Add(this.timeoutLabel);
            this.portConfigurationGroup.Controls.Add(this.timeoutTextBox);
            this.portConfigurationGroup.Controls.Add(this.baudRateLabel);
            this.portConfigurationGroup.Controls.Add(this.portLabel);
            this.portConfigurationGroup.Controls.Add(this.connectBtn);
            this.portConfigurationGroup.Controls.Add(this.baudRateComboBox);
            this.portConfigurationGroup.Controls.Add(this.portComboBox);
            this.portConfigurationGroup.Location = new System.Drawing.Point(20, 23);
            this.portConfigurationGroup.Margin = new System.Windows.Forms.Padding(6);
            this.portConfigurationGroup.Name = "portConfigurationGroup";
            this.portConfigurationGroup.Padding = new System.Windows.Forms.Padding(6);
            this.portConfigurationGroup.Size = new System.Drawing.Size(990, 235);
            this.portConfigurationGroup.TabIndex = 13;
            this.portConfigurationGroup.TabStop = false;
            this.portConfigurationGroup.Text = "Port Configuration";
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Location = new System.Drawing.Point(32, 173);
            this.timeoutLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(137, 25);
            this.timeoutLabel.TabIndex = 6;
            this.timeoutLabel.Text = "Timeout (ms)";
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.Location = new System.Drawing.Point(188, 167);
            this.timeoutTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.timeoutTextBox.Name = "timeoutTextBox";
            this.timeoutTextBox.Size = new System.Drawing.Size(94, 31);
            this.timeoutTextBox.TabIndex = 5;
            this.timeoutTextBox.Text = "500";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(32, 121);
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
            this.portLabel.Click += new System.EventHandler(this.PortLabel_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(784, 63);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(6);
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
            this.baudRateComboBox.Location = new System.Drawing.Point(188, 115);
            this.baudRateComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(134, 33);
            this.baudRateComboBox.TabIndex = 1;
            // 
            // portComboBox
            // 
            this.portComboBox.DisplayMember = "desc";
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(188, 67);
            this.portComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(460, 33);
            this.portComboBox.TabIndex = 0;
            this.portComboBox.ValueMember = "name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataReceivedRichTextBox);
            this.tabPage1.Controls.Add(this.commandLabel);
            this.tabPage1.Controls.Add(this.clearLogButton);
            this.tabPage1.Controls.Add(this.cmdTextBox);
            this.tabPage1.Controls.Add(this.sendBtn);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1537, 684);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Other";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataReceivedRichTextBox
            // 
            this.dataReceivedRichTextBox.Location = new System.Drawing.Point(558, 29);
            this.dataReceivedRichTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.dataReceivedRichTextBox.Name = "dataReceivedRichTextBox";
            this.dataReceivedRichTextBox.ReadOnly = true;
            this.dataReceivedRichTextBox.Size = new System.Drawing.Size(943, 558);
            this.dataReceivedRichTextBox.TabIndex = 9;
            this.dataReceivedRichTextBox.Text = "";
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(32, 60);
            this.commandLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(109, 25);
            this.commandLabel.TabIndex = 1;
            this.commandLabel.Text = "Command";
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(1351, 614);
            this.clearLogButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(150, 44);
            this.clearLogButton.TabIndex = 10;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(153, 57);
            this.cmdTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(196, 31);
            this.cmdTextBox.TabIndex = 0;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(380, 50);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(6);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(150, 44);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // smsTab
            // 
            this.smsTab.Controls.Add(this.SmsTabControl);
            this.smsTab.Location = new System.Drawing.Point(8, 39);
            this.smsTab.Margin = new System.Windows.Forms.Padding(4);
            this.smsTab.Name = "smsTab";
            this.smsTab.Padding = new System.Windows.Forms.Padding(4);
            this.smsTab.Size = new System.Drawing.Size(1537, 684);
            this.smsTab.TabIndex = 2;
            this.smsTab.Text = "SMS";
            this.smsTab.UseVisualStyleBackColor = true;
            // 
            // SmsTabControl
            // 
            this.SmsTabControl.Controls.Add(this.smsMessageTab);
            this.SmsTabControl.Controls.Add(this.smsInboxTab);
            this.SmsTabControl.Location = new System.Drawing.Point(6, 56);
            this.SmsTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.SmsTabControl.Name = "SmsTabControl";
            this.SmsTabControl.SelectedIndex = 0;
            this.SmsTabControl.Size = new System.Drawing.Size(1523, 623);
            this.SmsTabControl.TabIndex = 0;
            // 
            // smsMessageTab
            // 
            this.smsMessageTab.Controls.Add(this.smsMessageLabel);
            this.smsMessageTab.Controls.Add(this.pduLengthLabel);
            this.smsMessageTab.Controls.Add(this.pduTextBox);
            this.smsMessageTab.Controls.Add(this.smsMessageSendSmsButton);
            this.smsMessageTab.Controls.Add(this.label3);
            this.smsMessageTab.Controls.Add(this.label4);
            this.smsMessageTab.Controls.Add(this.smsMessageTextBox);
            this.smsMessageTab.Controls.Add(this.smsSettingsPDUGroup);
            this.smsMessageTab.Controls.Add(this.smsMessagePhoneNumberLabel);
            this.smsMessageTab.Controls.Add(this.smsMessagePhoneNumberTextBox);
            this.smsMessageTab.Location = new System.Drawing.Point(8, 39);
            this.smsMessageTab.Margin = new System.Windows.Forms.Padding(4);
            this.smsMessageTab.Name = "smsMessageTab";
            this.smsMessageTab.Padding = new System.Windows.Forms.Padding(4);
            this.smsMessageTab.Size = new System.Drawing.Size(1507, 576);
            this.smsMessageTab.TabIndex = 0;
            this.smsMessageTab.Text = "Message";
            this.smsMessageTab.UseVisualStyleBackColor = true;
            // 
            // smsMessageLabel
            // 
            this.smsMessageLabel.AutoSize = true;
            this.smsMessageLabel.Location = new System.Drawing.Point(16, 145);
            this.smsMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smsMessageLabel.Name = "smsMessageLabel";
            this.smsMessageLabel.Size = new System.Drawing.Size(100, 25);
            this.smsMessageLabel.TabIndex = 12;
            this.smsMessageLabel.Text = "Message";
            // 
            // pduLengthLabel
            // 
            this.pduLengthLabel.AutoSize = true;
            this.pduLengthLabel.Location = new System.Drawing.Point(621, 368);
            this.pduLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pduLengthLabel.Name = "pduLengthLabel";
            this.pduLengthLabel.Size = new System.Drawing.Size(24, 25);
            this.pduLengthLabel.TabIndex = 15;
            this.pduLengthLabel.Text = "0";
            // 
            // pduTextBox
            // 
            this.pduTextBox.Location = new System.Drawing.Point(21, 399);
            this.pduTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.pduTextBox.Multiline = true;
            this.pduTextBox.Name = "pduTextBox";
            this.pduTextBox.ReadOnly = true;
            this.pduTextBox.Size = new System.Drawing.Size(616, 157);
            this.pduTextBox.TabIndex = 13;
            // 
            // smsMessageSendSmsButton
            // 
            this.smsMessageSendSmsButton.Location = new System.Drawing.Point(22, 292);
            this.smsMessageSendSmsButton.Margin = new System.Windows.Forms.Padding(6);
            this.smsMessageSendSmsButton.Name = "smsMessageSendSmsButton";
            this.smsMessageSendSmsButton.Size = new System.Drawing.Size(150, 44);
            this.smsMessageSendSmsButton.TabIndex = 12;
            this.smsMessageSendSmsButton.Text = "Send SMS";
            this.smsMessageSendSmsButton.UseVisualStyleBackColor = true;
            this.smsMessageSendSmsButton.Click += new System.EventHandler(this.SmsMessageSendSmsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "PDU String";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 368);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Length:";
            // 
            // smsMessageTextBox
            // 
            this.smsMessageTextBox.Location = new System.Drawing.Point(22, 172);
            this.smsMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.smsMessageTextBox.Multiline = true;
            this.smsMessageTextBox.Name = "smsMessageTextBox";
            this.smsMessageTextBox.Size = new System.Drawing.Size(615, 96);
            this.smsMessageTextBox.TabIndex = 11;
            // 
            // smsSettingsPDUGroup
            // 
            this.smsSettingsPDUGroup.Controls.Add(this.requestStatusReportCheckBox);
            this.smsSettingsPDUGroup.Controls.Add(this.dcsComboBox);
            this.smsSettingsPDUGroup.Controls.Add(this.pidComboBox);
            this.smsSettingsPDUGroup.Controls.Add(this.label2);
            this.smsSettingsPDUGroup.Controls.Add(this.label1);
            this.smsSettingsPDUGroup.Location = new System.Drawing.Point(696, 87);
            this.smsSettingsPDUGroup.Margin = new System.Windows.Forms.Padding(4);
            this.smsSettingsPDUGroup.Name = "smsSettingsPDUGroup";
            this.smsSettingsPDUGroup.Padding = new System.Windows.Forms.Padding(4);
            this.smsSettingsPDUGroup.Size = new System.Drawing.Size(803, 469);
            this.smsSettingsPDUGroup.TabIndex = 1;
            this.smsSettingsPDUGroup.TabStop = false;
            this.smsSettingsPDUGroup.Text = "PDU Settings";
            // 
            // requestStatusReportCheckBox
            // 
            this.requestStatusReportCheckBox.AutoSize = true;
            this.requestStatusReportCheckBox.Location = new System.Drawing.Point(29, 174);
            this.requestStatusReportCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.requestStatusReportCheckBox.Name = "requestStatusReportCheckBox";
            this.requestStatusReportCheckBox.Size = new System.Drawing.Size(314, 29);
            this.requestStatusReportCheckBox.TabIndex = 19;
            this.requestStatusReportCheckBox.Text = "Request status report (SRR)";
            this.requestStatusReportCheckBox.UseVisualStyleBackColor = true;
            // 
            // dcsComboBox
            // 
            this.dcsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcsComboBox.FormattingEnabled = true;
            this.dcsComboBox.Location = new System.Drawing.Point(342, 106);
            this.dcsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.dcsComboBox.Name = "dcsComboBox";
            this.dcsComboBox.Size = new System.Drawing.Size(374, 33);
            this.dcsComboBox.TabIndex = 18;
            // 
            // pidComboBox
            // 
            this.pidComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pidComboBox.FormattingEnabled = true;
            this.pidComboBox.Location = new System.Drawing.Point(342, 52);
            this.pidComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.pidComboBox.Name = "pidComboBox";
            this.pidComboBox.Size = new System.Drawing.Size(374, 33);
            this.pidComboBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data Coding Scheme (DCS)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Protocol Identifier (PID)";
            // 
            // smsMessagePhoneNumberLabel
            // 
            this.smsMessagePhoneNumberLabel.AutoSize = true;
            this.smsMessagePhoneNumberLabel.Location = new System.Drawing.Point(16, 103);
            this.smsMessagePhoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.smsMessagePhoneNumberLabel.Name = "smsMessagePhoneNumberLabel";
            this.smsMessagePhoneNumberLabel.Size = new System.Drawing.Size(155, 25);
            this.smsMessagePhoneNumberLabel.TabIndex = 10;
            this.smsMessagePhoneNumberLabel.Text = "Phone Number";
            // 
            // smsMessagePhoneNumberTextBox
            // 
            this.smsMessagePhoneNumberTextBox.Location = new System.Drawing.Point(184, 99);
            this.smsMessagePhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.smsMessagePhoneNumberTextBox.Name = "smsMessagePhoneNumberTextBox";
            this.smsMessagePhoneNumberTextBox.Size = new System.Drawing.Size(196, 31);
            this.smsMessagePhoneNumberTextBox.TabIndex = 9;
            // 
            // smsInboxTab
            // 
            this.smsInboxTab.Controls.Add(this.smsInboxGrid);
            this.smsInboxTab.Controls.Add(this.button1);
            this.smsInboxTab.Location = new System.Drawing.Point(8, 39);
            this.smsInboxTab.Margin = new System.Windows.Forms.Padding(4);
            this.smsInboxTab.Name = "smsInboxTab";
            this.smsInboxTab.Padding = new System.Windows.Forms.Padding(4);
            this.smsInboxTab.Size = new System.Drawing.Size(1507, 576);
            this.smsInboxTab.TabIndex = 1;
            this.smsInboxTab.Text = "Inbox";
            this.smsInboxTab.UseVisualStyleBackColor = true;
            // 
            // smsInboxGrid
            // 
            this.smsInboxGrid.AllowUserToAddRows = false;
            this.smsInboxGrid.AllowUserToDeleteRows = false;
            this.smsInboxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.smsInboxGrid.Location = new System.Drawing.Point(16, 10);
            this.smsInboxGrid.Margin = new System.Windows.Forms.Padding(6);
            this.smsInboxGrid.Name = "smsInboxGrid";
            this.smsInboxGrid.ReadOnly = true;
            this.smsInboxGrid.RowHeadersWidth = 82;
            this.smsInboxGrid.Size = new System.Drawing.Size(1481, 498);
            this.smsInboxGrid.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 519);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Inbox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.smsTab);
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Location = new System.Drawing.Point(20, 294);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(6);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1553, 731);
            this.mainTabControl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1040);
            this.Controls.Add(this.portConfigurationGroup);
            this.Controls.Add(this.connectionGroup);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "PDU Tester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.connectionGroup.ResumeLayout(false);
            this.connectionGroup.PerformLayout();
            this.portConfigurationGroup.ResumeLayout(false);
            this.portConfigurationGroup.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.smsTab.ResumeLayout(false);
            this.SmsTabControl.ResumeLayout(false);
            this.smsMessageTab.ResumeLayout(false);
            this.smsMessageTab.PerformLayout();
            this.smsSettingsPDUGroup.ResumeLayout(false);
            this.smsSettingsPDUGroup.PerformLayout();
            this.smsInboxTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smsInboxGrid)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox connectionGroup;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label connectionManufacturerLabel;
        private System.Windows.Forms.Label connectionDeviceModelLabel;
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
        private System.Windows.Forms.Label batteryLevel;
        private System.Windows.Forms.Label batteryLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox dataReceivedRichTextBox;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TabPage smsTab;
        private System.Windows.Forms.TabControl SmsTabControl;
        private System.Windows.Forms.TabPage smsMessageTab;
        private System.Windows.Forms.GroupBox smsSettingsPDUGroup;
        private System.Windows.Forms.CheckBox requestStatusReportCheckBox;
        private System.Windows.Forms.ComboBox dcsComboBox;
        private System.Windows.Forms.ComboBox pidComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label smsMessageLabel;
        private System.Windows.Forms.Button smsMessageSendSmsButton;
        private System.Windows.Forms.TextBox smsMessageTextBox;
        private System.Windows.Forms.Label smsMessagePhoneNumberLabel;
        private System.Windows.Forms.TextBox smsMessagePhoneNumberTextBox;
        private System.Windows.Forms.TabPage smsInboxTab;
        private System.Windows.Forms.DataGridView smsInboxGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pduTextBox;
        private System.Windows.Forms.Label pduLengthLabel;
        private System.Windows.Forms.Label label4;
    }
}

