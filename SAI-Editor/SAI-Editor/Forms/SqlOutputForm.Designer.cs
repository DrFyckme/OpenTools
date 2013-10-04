﻿namespace SAI_Editor.Forms
{
    partial class SqlOutputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlOutputForm));
            this.richTextBoxSqlOutput = new System.Windows.Forms.RichTextBox();
            this.buttonExecuteScript = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // richTextBoxSqlOutput
            // 
            this.richTextBoxSqlOutput.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxSqlOutput.Name = "richTextBoxSqlOutput";
            this.richTextBoxSqlOutput.Size = new System.Drawing.Size(819, 322);
            this.richTextBoxSqlOutput.TabIndex = 0;
            this.richTextBoxSqlOutput.Text = "";
            // 
            // buttonExecuteScript
            // 
            this.buttonExecuteScript.Location = new System.Drawing.Point(746, 340);
            this.buttonExecuteScript.Name = "buttonExecuteScript";
            this.buttonExecuteScript.Size = new System.Drawing.Size(85, 23);
            this.buttonExecuteScript.TabIndex = 1;
            this.buttonExecuteScript.Text = "Execute script";
            this.buttonExecuteScript.UseVisualStyleBackColor = true;
            this.buttonExecuteScript.Click += new System.EventHandler(this.buttonExecuteScript_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(655, 340);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(85, 23);
            this.buttonSaveToFile.TabIndex = 2;
            this.buttonSaveToFile.Text = "Save to file";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // SqlOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 368);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonExecuteScript);
            this.Controls.Add(this.richTextBoxSqlOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SqlOutputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Output";
            this.Load += new System.EventHandler(this.SqlOutputForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SqlOutputForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSqlOutput;
        private System.Windows.Forms.Button buttonExecuteScript;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}