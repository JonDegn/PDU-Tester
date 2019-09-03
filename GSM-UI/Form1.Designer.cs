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
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.voiceCallTab = new System.Windows.Forms.TabPage();
            this.OutgoingVoiceCallGroupBox = new System.Windows.Forms.GroupBox();
            this.callNumberLabel = new System.Windows.Forms.Label();
            this.incomingVoiceCallGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.answerBtn = new System.Windows.Forms.Button();
            this.dataReceivedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.redialButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.voiceCallTab.SuspendLayout();
            this.OutgoingVoiceCallGroupBox.SuspendLayout();
            this.incomingVoiceCallGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(79, 33);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(100, 20);
            this.cmdTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTabPage);
            this.tabControl1.Controls.Add(this.voiceCallTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 380);
            this.tabControl1.TabIndex = 8;
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.label1);
            this.mainTabPage.Controls.Add(this.cmdTextBox);
            this.mainTabPage.Controls.Add(this.sendBtn);
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(491, 354);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Main";
            this.mainTabPage.UseVisualStyleBackColor = true;
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
            // OutgoingVoiceCallGroupBox
            // 
            this.OutgoingVoiceCallGroupBox.Controls.Add(this.redialButton);
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
            // incomingVoiceCallGroupBox
            // 
            this.incomingVoiceCallGroupBox.Controls.Add(this.phoneNumberLabel);
            this.incomingVoiceCallGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.incomingVoiceCallGroupBox.Controls.Add(this.answerBtn);
            this.incomingVoiceCallGroupBox.Controls.Add(this.button1);
            this.incomingVoiceCallGroupBox.Location = new System.Drawing.Point(23, 187);
            this.incomingVoiceCallGroupBox.Name = "incomingVoiceCallGroupBox";
            this.incomingVoiceCallGroupBox.Size = new System.Drawing.Size(427, 109);
            this.incomingVoiceCallGroupBox.TabIndex = 9;
            this.incomingVoiceCallGroupBox.TabStop = false;
            this.incomingVoiceCallGroupBox.Text = "Incoming";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hang Up";
            this.button1.UseVisualStyleBackColor = true;
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
            // dataReceivedRichTextBox
            // 
            this.dataReceivedRichTextBox.Location = new System.Drawing.Point(517, 80);
            this.dataReceivedRichTextBox.Name = "dataReceivedRichTextBox";
            this.dataReceivedRichTextBox.ReadOnly = true;
            this.dataReceivedRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.dataReceivedRichTextBox.Size = new System.Drawing.Size(271, 354);
            this.dataReceivedRichTextBox.TabIndex = 9;
            this.dataReceivedRichTextBox.Text = "";
            // 
            // redialButton
            // 
            this.redialButton.Location = new System.Drawing.Point(326, 35);
            this.redialButton.Name = "redialButton";
            this.redialButton.Size = new System.Drawing.Size(75, 23);
            this.redialButton.TabIndex = 9;
            this.redialButton.Text = "Redial";
            this.redialButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataReceivedRichTextBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.mainTabPage.PerformLayout();
            this.voiceCallTab.ResumeLayout(false);
            this.OutgoingVoiceCallGroupBox.ResumeLayout(false);
            this.OutgoingVoiceCallGroupBox.PerformLayout();
            this.incomingVoiceCallGroupBox.ResumeLayout(false);
            this.incomingVoiceCallGroupBox.PerformLayout();
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
        private System.Windows.Forms.TabPage mainTabPage;
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
    }
}

