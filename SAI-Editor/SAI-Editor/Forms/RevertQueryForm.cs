﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAI_Editor.Forms
{
    public partial class RevertQueryForm : Form
    {
        public RevertQueryForm()
        {
            InitializeComponent();
        }

        private void RevertQueryForm_Load(object sender, EventArgs e)
        {
            calenderScriptsToRevert.TodayDate = DateTime.Now;
            FillListViewWithDate();
        }

        private void calenderScriptsToRevert_DateChanged(object sender, DateRangeEventArgs e)
        {
            FillListViewWithDate();
        }

        private void FillListViewWithDate()
        {
            listViewScripts.Items.Clear();
            string[] allFiles = Directory.GetFiles("Reverts");

            for (int i = 0; i < allFiles.Length; ++i)
            {
                DateTime createTime = File.GetCreationTime(allFiles[i]);

                //! If the file was created after or before the selection of the user, don't list it
                if (createTime.CompareTo(calenderScriptsToRevert.SelectionStart) < 0 && createTime.CompareTo(calenderScriptsToRevert.SelectionEnd) < 0)
                    continue;

                listViewScripts.Items.Add(allFiles[i].Replace(@"Reverts\", "").Replace(".sql", "").Replace(";", ":"));
            }
        }

        private void buttonExecuteSelectedScript_Click(object sender, EventArgs e)
        {
            ExecutedSelectedScript();
        }

        private async void ExecutedSelectedScript()
        {
            if (listViewScripts.SelectedItems.Count == 0)
                return;

            string fileName = "Reverts\\" + listViewScripts.SelectedItems[0].Text + ".sql".Replace(":", ";");

            if (await SAI_Editor_Manager.Instance.worldDatabase.ExecuteNonQuery(File.ReadAllText(fileName)))
                MessageBox.Show("The query has been executed succesfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonExecuteSelectedScript.Enabled = listViewScripts.SelectedItems.Count > 0;
        }

        private void RevertQueryForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void listViewScripts_DoubleClick(object sender, EventArgs e)
        {
            ExecutedSelectedScript();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewScripts.SelectedItems.Count == 0)
                return;

            string fileName = @"Reverts\" + listViewScripts.SelectedItems[0].Text + ".sql";
            fileName = fileName.Replace(":", ";");
            StartProcess(fileName);
        }

        private void openFileWithToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewScripts.SelectedItems.Count == 0)
                return;

            string fileName = @"Reverts\" + listViewScripts.SelectedItems[0].Text + ".sql";
            fileName = fileName.Replace(":", ";");
            StartProcess("rundll32.exe", "shell32.dll, OpenAs_RunDLL " + fileName);
        }

        private void openDirectoryOfFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewScripts.SelectedItems.Count == 0)
                return;

            string fileName = @"Reverts\" + listViewScripts.SelectedItems[0].Text + ".sql";
            fileName = fileName.Replace(":", ";");
            StartProcess("explorer.exe", String.Format("/select,\"{0}\"", fileName));
        }

        private void StartProcess(string filename, string argument = "")
        {
            try
            {
                Process.Start(filename, argument);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(String.Format("The process '{0}' could not be opened!", Path.GetFileName(filename)), "An error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewScripts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listViewScripts.FocusedItem.Bounds.Contains(e.Location))
                    listViewContextMenu.Show(Cursor.Position);
        }

        private void deleteRevertQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewScripts.SelectedItems.Count == 0)
                return;

            if (MessageBox.Show("Are you sure you want to delete this revert query permanently? This action can not be undone!", "Are you sure!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            string fileName = @"Reverts\" + listViewScripts.SelectedItems[0].Text + ".sql";
            fileName = fileName.Replace(":", ";");
            File.Delete(fileName);
            FillListViewWithDate();
        }
    }
}
