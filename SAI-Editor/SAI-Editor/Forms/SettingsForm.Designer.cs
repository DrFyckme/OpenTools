﻿namespace SAI_Editor
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.buttonExitSettings = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.checkBoxAutoGenerateComments = new System.Windows.Forms.CheckBox();
            this.checkBoxShowTooltipsPermanently = new System.Windows.Forms.CheckBox();
            this.checkBoxChangeStaticInfo = new System.Windows.Forms.CheckBox();
            this.checkBoxPromptExecuteQuery = new System.Windows.Forms.CheckBox();
            this.textBoxAnimationSpeed = new System.Windows.Forms.TextBox();
            this.labelAnimationSpeed = new System.Windows.Forms.Label();
            this.trackBarAnimationSpeed = new System.Windows.Forms.TrackBar();
            this.checkBoxPromptToQuit = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoSaveSettings = new System.Windows.Forms.CheckBox();
            this.checkBoxLoadScriptInstantly = new System.Windows.Forms.CheckBox();
            this.checkBoxInstantExpand = new System.Windows.Forms.CheckBox();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.buttonSearchForWorldDb = new System.Windows.Forms.Button();
            this.checkBoxHidePass = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoConnect = new System.Windows.Forms.CheckBox();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxWorldDatabase = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDefaultSettings = new System.Windows.Forms.Button();
            this.checkBoxCreateRevertQuery = new System.Windows.Forms.CheckBox();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnimationSpeed)).BeginInit();
            this.tabControlSettings.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExitSettings
            // 
            this.buttonExitSettings.Location = new System.Drawing.Point(192, 317);
            this.buttonExitSettings.Name = "buttonExitSettings";
            this.buttonExitSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonExitSettings.TabIndex = 9;
            this.buttonExitSettings.Text = "Exit";
            this.buttonExitSettings.UseVisualStyleBackColor = true;
            this.buttonExitSettings.Click += new System.EventHandler(this.buttonExitSettings_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(12, 317);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSettings.TabIndex = 7;
            this.buttonSaveSettings.Text = "Save";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.checkBoxCreateRevertQuery);
            this.tabPageGeneral.Controls.Add(this.checkBoxAutoGenerateComments);
            this.tabPageGeneral.Controls.Add(this.checkBoxShowTooltipsPermanently);
            this.tabPageGeneral.Controls.Add(this.checkBoxChangeStaticInfo);
            this.tabPageGeneral.Controls.Add(this.checkBoxPromptExecuteQuery);
            this.tabPageGeneral.Controls.Add(this.textBoxAnimationSpeed);
            this.tabPageGeneral.Controls.Add(this.labelAnimationSpeed);
            this.tabPageGeneral.Controls.Add(this.trackBarAnimationSpeed);
            this.tabPageGeneral.Controls.Add(this.checkBoxPromptToQuit);
            this.tabPageGeneral.Controls.Add(this.checkBoxAutoSaveSettings);
            this.tabPageGeneral.Controls.Add(this.checkBoxLoadScriptInstantly);
            this.tabPageGeneral.Controls.Add(this.checkBoxInstantExpand);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(247, 277);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoGenerateComments
            // 
            this.checkBoxAutoGenerateComments.AutoSize = true;
            this.checkBoxAutoGenerateComments.Location = new System.Drawing.Point(6, 167);
            this.checkBoxAutoGenerateComments.Name = "checkBoxAutoGenerateComments";
            this.checkBoxAutoGenerateComments.Size = new System.Drawing.Size(184, 17);
            this.checkBoxAutoGenerateComments.TabIndex = 13;
            this.checkBoxAutoGenerateComments.Text = "Automatically generate comments";
            this.checkBoxAutoGenerateComments.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowTooltipsPermanently
            // 
            this.checkBoxShowTooltipsPermanently.AutoSize = true;
            this.checkBoxShowTooltipsPermanently.Location = new System.Drawing.Point(6, 144);
            this.checkBoxShowTooltipsPermanently.Name = "checkBoxShowTooltipsPermanently";
            this.checkBoxShowTooltipsPermanently.Size = new System.Drawing.Size(149, 17);
            this.checkBoxShowTooltipsPermanently.TabIndex = 12;
            this.checkBoxShowTooltipsPermanently.Text = "Show tooltips permanently";
            this.checkBoxShowTooltipsPermanently.UseVisualStyleBackColor = true;
            // 
            // checkBoxChangeStaticInfo
            // 
            this.checkBoxChangeStaticInfo.AutoSize = true;
            this.checkBoxChangeStaticInfo.Checked = true;
            this.checkBoxChangeStaticInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChangeStaticInfo.Location = new System.Drawing.Point(6, 121);
            this.checkBoxChangeStaticInfo.Name = "checkBoxChangeStaticInfo";
            this.checkBoxChangeStaticInfo.Size = new System.Drawing.Size(219, 17);
            this.checkBoxChangeStaticInfo.TabIndex = 11;
            this.checkBoxChangeStaticInfo.Text = "Change static script information on select";
            this.checkBoxChangeStaticInfo.UseVisualStyleBackColor = true;
            // 
            // checkBoxPromptExecuteQuery
            // 
            this.checkBoxPromptExecuteQuery.AutoSize = true;
            this.checkBoxPromptExecuteQuery.Checked = true;
            this.checkBoxPromptExecuteQuery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPromptExecuteQuery.Location = new System.Drawing.Point(6, 98);
            this.checkBoxPromptExecuteQuery.Name = "checkBoxPromptExecuteQuery";
            this.checkBoxPromptExecuteQuery.Size = new System.Drawing.Size(231, 17);
            this.checkBoxPromptExecuteQuery.TabIndex = 10;
            this.checkBoxPromptExecuteQuery.Text = "Ask me if I\'m sure I want to execute a query";
            this.checkBoxPromptExecuteQuery.UseVisualStyleBackColor = true;
            // 
            // textBoxAnimationSpeed
            // 
            this.textBoxAnimationSpeed.Enabled = false;
            this.textBoxAnimationSpeed.Location = new System.Drawing.Point(103, 228);
            this.textBoxAnimationSpeed.Name = "textBoxAnimationSpeed";
            this.textBoxAnimationSpeed.Size = new System.Drawing.Size(37, 20);
            this.textBoxAnimationSpeed.TabIndex = 8;
            this.textBoxAnimationSpeed.Text = "10";
            this.textBoxAnimationSpeed.TextChanged += new System.EventHandler(this.textBoxAnimationSpeed_TextChanged);
            // 
            // labelAnimationSpeed
            // 
            this.labelAnimationSpeed.AutoSize = true;
            this.labelAnimationSpeed.Location = new System.Drawing.Point(6, 231);
            this.labelAnimationSpeed.Name = "labelAnimationSpeed";
            this.labelAnimationSpeed.Size = new System.Drawing.Size(91, 13);
            this.labelAnimationSpeed.TabIndex = 7;
            this.labelAnimationSpeed.Text = "Animation speed: ";
            // 
            // trackBarAnimationSpeed
            // 
            this.trackBarAnimationSpeed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBarAnimationSpeed.Location = new System.Drawing.Point(-4, 250);
            this.trackBarAnimationSpeed.Maximum = 12;
            this.trackBarAnimationSpeed.Minimum = 1;
            this.trackBarAnimationSpeed.Name = "trackBarAnimationSpeed";
            this.trackBarAnimationSpeed.Size = new System.Drawing.Size(255, 45);
            this.trackBarAnimationSpeed.TabIndex = 6;
            this.trackBarAnimationSpeed.Value = 10;
            this.trackBarAnimationSpeed.ValueChanged += new System.EventHandler(this.trackBarAnimationSpeed_ValueChanged);
            // 
            // checkBoxPromptToQuit
            // 
            this.checkBoxPromptToQuit.AutoSize = true;
            this.checkBoxPromptToQuit.Checked = true;
            this.checkBoxPromptToQuit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPromptToQuit.Location = new System.Drawing.Point(6, 75);
            this.checkBoxPromptToQuit.Name = "checkBoxPromptToQuit";
            this.checkBoxPromptToQuit.Size = new System.Drawing.Size(171, 17);
            this.checkBoxPromptToQuit.TabIndex = 3;
            this.checkBoxPromptToQuit.Text = "Ask me if I\'m sure I want to exit";
            this.checkBoxPromptToQuit.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoSaveSettings
            // 
            this.checkBoxAutoSaveSettings.AutoSize = true;
            this.checkBoxAutoSaveSettings.Location = new System.Drawing.Point(6, 6);
            this.checkBoxAutoSaveSettings.Name = "checkBoxAutoSaveSettings";
            this.checkBoxAutoSaveSettings.Size = new System.Drawing.Size(113, 17);
            this.checkBoxAutoSaveSettings.TabIndex = 0;
            this.checkBoxAutoSaveSettings.Text = "Auto save settings";
            this.checkBoxAutoSaveSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoadScriptInstantly
            // 
            this.checkBoxLoadScriptInstantly.AutoSize = true;
            this.checkBoxLoadScriptInstantly.Checked = true;
            this.checkBoxLoadScriptInstantly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoadScriptInstantly.Location = new System.Drawing.Point(6, 52);
            this.checkBoxLoadScriptInstantly.Name = "checkBoxLoadScriptInstantly";
            this.checkBoxLoadScriptInstantly.Size = new System.Drawing.Size(159, 17);
            this.checkBoxLoadScriptInstantly.TabIndex = 2;
            this.checkBoxLoadScriptInstantly.Text = "Load script of selected entry";
            this.checkBoxLoadScriptInstantly.UseVisualStyleBackColor = true;
            // 
            // checkBoxInstantExpand
            // 
            this.checkBoxInstantExpand.AutoSize = true;
            this.checkBoxInstantExpand.Location = new System.Drawing.Point(6, 29);
            this.checkBoxInstantExpand.Name = "checkBoxInstantExpand";
            this.checkBoxInstantExpand.Size = new System.Drawing.Size(166, 17);
            this.checkBoxInstantExpand.TabIndex = 1;
            this.checkBoxInstantExpand.Text = "Expand and contract instantly";
            this.checkBoxInstantExpand.UseVisualStyleBackColor = true;
            this.checkBoxInstantExpand.CheckedChanged += new System.EventHandler(this.checkBoxExpandInstantly_CheckedChanged);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageGeneral);
            this.tabControlSettings.Controls.Add(this.tabPageConnection);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 8);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(255, 303);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.buttonTestConnection);
            this.tabPageConnection.Controls.Add(this.buttonSearchForWorldDb);
            this.tabPageConnection.Controls.Add(this.checkBoxHidePass);
            this.tabPageConnection.Controls.Add(this.checkBoxAutoConnect);
            this.tabPageConnection.Controls.Add(this.textBoxHost);
            this.tabPageConnection.Controls.Add(this.textBoxUsername);
            this.tabPageConnection.Controls.Add(this.textBoxPassword);
            this.tabPageConnection.Controls.Add(this.textBoxWorldDatabase);
            this.tabPageConnection.Controls.Add(this.textBoxPort);
            this.tabPageConnection.Controls.Add(this.label3);
            this.tabPageConnection.Controls.Add(this.label4);
            this.tabPageConnection.Controls.Add(this.label5);
            this.tabPageConnection.Controls.Add(this.label6);
            this.tabPageConnection.Controls.Add(this.label7);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Size = new System.Drawing.Size(247, 277);
            this.tabPageConnection.TabIndex = 1;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(138, 193);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(98, 23);
            this.buttonTestConnection.TabIndex = 31;
            this.buttonTestConnection.Text = "Test connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // buttonSearchForWorldDb
            // 
            this.buttonSearchForWorldDb.Location = new System.Drawing.Point(212, 91);
            this.buttonSearchForWorldDb.Name = "buttonSearchForWorldDb";
            this.buttonSearchForWorldDb.Size = new System.Drawing.Size(24, 22);
            this.buttonSearchForWorldDb.TabIndex = 30;
            this.buttonSearchForWorldDb.Text = "...";
            this.buttonSearchForWorldDb.UseVisualStyleBackColor = true;
            this.buttonSearchForWorldDb.Click += new System.EventHandler(this.buttonSearchForWorldDb_Click);
            // 
            // checkBoxHidePass
            // 
            this.checkBoxHidePass.AutoSize = true;
            this.checkBoxHidePass.Location = new System.Drawing.Point(124, 147);
            this.checkBoxHidePass.Name = "checkBoxHidePass";
            this.checkBoxHidePass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxHidePass.Size = new System.Drawing.Size(112, 17);
            this.checkBoxHidePass.TabIndex = 29;
            this.checkBoxHidePass.Text = "Hide my password";
            this.checkBoxHidePass.UseVisualStyleBackColor = true;
            this.checkBoxHidePass.CheckedChanged += new System.EventHandler(this.checkBoxDontHidePass_CheckedChanged);
            // 
            // checkBoxAutoConnect
            // 
            this.checkBoxAutoConnect.AutoSize = true;
            this.checkBoxAutoConnect.Location = new System.Drawing.Point(146, 170);
            this.checkBoxAutoConnect.Name = "checkBoxAutoConnect";
            this.checkBoxAutoConnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAutoConnect.Size = new System.Drawing.Size(90, 17);
            this.checkBoxAutoConnect.TabIndex = 5;
            this.checkBoxAutoConnect.Text = "Auto connect";
            this.checkBoxAutoConnect.UseVisualStyleBackColor = true;
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(106, 5);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(130, 20);
            this.textBoxHost.TabIndex = 0;
            this.textBoxHost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.settingTextBox_KeyDown);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(106, 34);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(130, 20);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.settingTextBox_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(106, 63);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(130, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.settingTextBox_KeyDown);
            // 
            // textBoxWorldDatabase
            // 
            this.textBoxWorldDatabase.Location = new System.Drawing.Point(106, 92);
            this.textBoxWorldDatabase.Name = "textBoxWorldDatabase";
            this.textBoxWorldDatabase.Size = new System.Drawing.Size(106, 20);
            this.textBoxWorldDatabase.TabIndex = 3;
            this.textBoxWorldDatabase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.settingTextBox_KeyDown);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(106, 121);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(130, 20);
            this.textBoxPort.TabIndex = 4;
            this.textBoxPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.settingTextBox_KeyDown);
            this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericField_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "World Database:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Host:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Port:";
            // 
            // buttonDefaultSettings
            // 
            this.buttonDefaultSettings.Location = new System.Drawing.Point(102, 317);
            this.buttonDefaultSettings.Name = "buttonDefaultSettings";
            this.buttonDefaultSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonDefaultSettings.TabIndex = 8;
            this.buttonDefaultSettings.Text = "Default";
            this.buttonDefaultSettings.UseVisualStyleBackColor = true;
            this.buttonDefaultSettings.Click += new System.EventHandler(this.buttonClearSettings_Click);
            // 
            // checkBoxCreateRevertQuery
            // 
            this.checkBoxCreateRevertQuery.AutoSize = true;
            this.checkBoxCreateRevertQuery.Location = new System.Drawing.Point(6, 190);
            this.checkBoxCreateRevertQuery.Name = "checkBoxCreateRevertQuery";
            this.checkBoxCreateRevertQuery.Size = new System.Drawing.Size(181, 17);
            this.checkBoxCreateRevertQuery.TabIndex = 10;
            this.checkBoxCreateRevertQuery.Text = "Create a revert query on execute";
            this.checkBoxCreateRevertQuery.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 352);
            this.Controls.Add(this.buttonDefaultSettings);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.buttonExitSettings);
            this.Controls.Add(this.tabControlSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SAI-Editor Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnimationSpeed)).EndInit();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitSettings;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.Button buttonDefaultSettings;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.CheckBox checkBoxAutoConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxInstantExpand;
        private System.Windows.Forms.CheckBox checkBoxLoadScriptInstantly;
        private System.Windows.Forms.CheckBox checkBoxAutoSaveSettings;
        private System.Windows.Forms.CheckBox checkBoxPromptToQuit;
        private System.Windows.Forms.Label labelAnimationSpeed;
        private System.Windows.Forms.TrackBar trackBarAnimationSpeed;
        private System.Windows.Forms.TextBox textBoxAnimationSpeed;
        private System.Windows.Forms.CheckBox checkBoxHidePass;
        private System.Windows.Forms.CheckBox checkBoxPromptExecuteQuery;
        private System.Windows.Forms.CheckBox checkBoxChangeStaticInfo;
        private System.Windows.Forms.Button buttonSearchForWorldDb;
        public System.Windows.Forms.TextBox textBoxHost;
        public System.Windows.Forms.TextBox textBoxUsername;
        public System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.TextBox textBoxWorldDatabase;
        public System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.CheckBox checkBoxShowTooltipsPermanently;
        private System.Windows.Forms.CheckBox checkBoxAutoGenerateComments;
        private System.Windows.Forms.CheckBox checkBoxCreateRevertQuery;

    }
}