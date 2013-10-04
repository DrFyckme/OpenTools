﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAI_Editor.Database.Classes;
using SAI_Editor.Classes;
using System.IO;
using System.Diagnostics;
using SAI_Editor.Properties;

namespace SAI_Editor.Forms
{
    public partial class SqlOutputForm : Form
    {
        private List<SmartScript> smartScripts = null;
        private EntryOrGuidAndSourceType originalEntryOrGuidAndSourceType = new EntryOrGuidAndSourceType();

        public SqlOutputForm(List<SmartScript> smartScripts)
        {
            InitializeComponent();

            this.smartScripts = smartScripts;
        }

        public void SqlOutputForm_Load(object sender, EventArgs e)
        {
            this.originalEntryOrGuidAndSourceType = ((MainForm)Owner).originalEntryOrGuidAndSourceType;
            richTextBoxSqlOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
            buttonExecuteScript.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            buttonSaveToFile.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            ExportSqlToTextbox();
        }

        private List<EntryOrGuidAndSourceType> GetUniqueEntriesOrGuidsAndSourceTypes()
        {
            List<EntryOrGuidAndSourceType> entriesOrGuidsAndSourceTypes = new List<EntryOrGuidAndSourceType>();

            foreach (SmartScript smartScript in smartScripts)
            {
                EntryOrGuidAndSourceType entryOrGuidAndSourceType = new EntryOrGuidAndSourceType();
                entryOrGuidAndSourceType.entryOrGuid = smartScript.entryorguid;
                entryOrGuidAndSourceType.sourceType = (SourceTypes)smartScript.source_type;

                if (entriesOrGuidsAndSourceTypes.Contains(entryOrGuidAndSourceType))
                    continue;

                entriesOrGuidsAndSourceTypes.Add(entryOrGuidAndSourceType);
            }

            return entriesOrGuidsAndSourceTypes;
        }

        private async void ExportSqlToTextbox()
        {
            if (smartScripts == null || smartScripts.Count == 0)
                return;

            List<EntryOrGuidAndSourceType> entriesOrGuidsAndSourceTypes = GetUniqueEntriesOrGuidsAndSourceTypes();

            string sourceName = await SAI_Editor_Manager.Instance.worldDatabase.GetObjectNameByIdOrGuidAndSourceType(originalEntryOrGuidAndSourceType.sourceType, originalEntryOrGuidAndSourceType.entryOrGuid);
            string sourceSet = originalEntryOrGuidAndSourceType.entryOrGuid < 0 ? "@GUID" : "@ENTRY";

            richTextBoxSqlOutput.Text += "-- " + sourceName + " SAI\n";
            richTextBoxSqlOutput.Text += "SET " + sourceSet + " := " + originalEntryOrGuidAndSourceType.entryOrGuid + ";\n";

            if (entriesOrGuidsAndSourceTypes.Count == 1)
            {
                switch ((SourceTypes)originalEntryOrGuidAndSourceType.sourceType)
                {
                    case SourceTypes.SourceTypeCreature:
                        richTextBoxSqlOutput.Text += "UPDATE `creature_template` SET `AIName`=" + '"' + "SmartAI" + '"' + " WHERE `entry`=" + sourceSet + ";\n";
                        break;
                    case SourceTypes.SourceTypeGameobject:
                        richTextBoxSqlOutput.Text += "UPDATE `gameobject_template` SET `AIName`=" + '"' + "SmartGameObjectAI" + '"' + " WHERE `entry`=" + sourceSet + ";\n";
                        break;
                    case SourceTypes.SourceTypeAreaTrigger:
                        richTextBoxSqlOutput.Text += "DELETE FROM `areatrigger_scripts` WHERE `entry`=" + sourceSet + ";\n";
                        richTextBoxSqlOutput.Text += "INSERT INTO `areatrigger_scripts` VALUES (" + sourceSet + "," + '"' + "SmartTrigger" + '"' + ");\n";
                        break;
                    case SourceTypes.SourceTypeScriptedActionlist:
                        // todo
                        break;
                }

                richTextBoxSqlOutput.Text += "DELETE FROM `smart_scripts` WHERE `entryorguid`=" + sourceSet + " AND `source_type`=" + (int)originalEntryOrGuidAndSourceType.sourceType + ";\n";
            }
            else
            {
                foreach (EntryOrGuidAndSourceType entryOrGuidAndSourceType in entriesOrGuidsAndSourceTypes)
                {
                    switch ((SourceTypes)entryOrGuidAndSourceType.sourceType)
                    {
                        case SourceTypes.SourceTypeCreature:
                            richTextBoxSqlOutput.Text += "UPDATE `creature_template` SET `AIName`=" + '"' + "SmartAI" + '"' + " WHERE `entry`=" + sourceSet + ";\n";
                            break;
                        case SourceTypes.SourceTypeGameobject:
                            richTextBoxSqlOutput.Text += "UPDATE `gameobject_template` SET `AIName`=" + '"' + "SmartGameObjectAI" + '"' + " WHERE `entry`=" + sourceSet + ";\n";
                            break;
                        case SourceTypes.SourceTypeAreaTrigger:
                            richTextBoxSqlOutput.Text += "DELETE FROM `areatrigger_scripts` WHERE `entry`=" + sourceSet + ";\n";
                            richTextBoxSqlOutput.Text += "INSERT INTO areatrigger_scripts VALUES (" + sourceSet + "," + '"' + "SmartTrigger" + '"' + ");\n";
                            break;
                        case SourceTypes.SourceTypeScriptedActionlist:
                            // todo
                            break;
                    }
                }

                richTextBoxSqlOutput.Text += "DELETE FROM `smart_scripts` WHERE `entryorguid` IN (";

                for (int i = 0; i < entriesOrGuidsAndSourceTypes.Count; ++i)
                {
                    if (i == entriesOrGuidsAndSourceTypes.Count - 1)
                        richTextBoxSqlOutput.Text += entriesOrGuidsAndSourceTypes[i].entryOrGuid + ")";
                    else
                        richTextBoxSqlOutput.Text += entriesOrGuidsAndSourceTypes[i].entryOrGuid + ",";
                }

                richTextBoxSqlOutput.Text += " AND `source_type` IN (";
                List<int> sourceTypesAdded = new List<int>();

                for (int i = 0; i < entriesOrGuidsAndSourceTypes.Count; ++i)
                {
                    if (sourceTypesAdded.Contains((int)entriesOrGuidsAndSourceTypes[i].sourceType))
                        continue;

                    if (i != 0)
                        richTextBoxSqlOutput.Text += ",";

                    richTextBoxSqlOutput.Text += (int)entriesOrGuidsAndSourceTypes[i].sourceType;
                    sourceTypesAdded.Add((int)entriesOrGuidsAndSourceTypes[i].sourceType);
                }

                richTextBoxSqlOutput.Text += ");\n";
            }

            richTextBoxSqlOutput.Text += "INSERT INTO `smart_scripts` (`entryorguid`,`source_type`,`id`,`link`,`event_type`,`event_phase_mask`,`event_chance`,`event_flags`,`event_param1`,`event_param2`,`event_param3`,`event_param4`,`action_type`,`action_param1`,`action_param2`,`action_param3`,`action_param4`,`action_param5`,`action_param6`,`target_type`,`target_param1`,`target_param2`,`target_param3`,`target_x`,`target_y`,`target_z`,`target_o`,`comment`) VALUES\n";

            for (int i = 0; i < smartScripts.Count; ++i)
            {
                SmartScript smartScript = smartScripts[i];
                string actualSourceSet = sourceSet;

                if (originalEntryOrGuidAndSourceType.entryOrGuid != smartScripts[i].entryorguid)
                    actualSourceSet = smartScripts[i].entryorguid.ToString();

                richTextBoxSqlOutput.Text += "(" + actualSourceSet + "," + smartScript.source_type + "," + smartScript.id + "," + smartScript.link + "," + smartScript.event_type + "," +
                                              smartScript.event_phase_mask + "," + smartScript.event_chance + "," + smartScript.event_flags + "," + smartScript.event_param1 + "," +
                                              smartScript.event_param2 + "," + smartScript.event_param3 + "," + smartScript.event_param4 + "," + smartScript.action_type + "," +
                                              smartScript.action_param1 + "," + smartScript.action_param2 + "," + smartScript.action_param3 + "," + smartScript.action_param4 + "," +
                                              smartScript.action_param5 + "," + smartScript.action_param6 + "," + smartScript.target_type + "," + smartScript.target_param1 + "," +
                                              smartScript.target_param2 + "," + smartScript.target_param3 + "," + smartScript.target_x + "," + smartScript.target_y + "," +
                                              smartScript.target_z + "," + smartScript.target_o + "," + '"' + smartScript.comment + '"' + ")";

                if (i == smartScripts.Count - 1)
                    richTextBoxSqlOutput.Text += ";";
                else
                    richTextBoxSqlOutput.Text += ",";

                richTextBoxSqlOutput.Text += "\n"; //! White line at end of script to make it easier to select
            }

            richTextBoxSqlOutput.Text = richTextBoxSqlOutput.Text.Replace(originalEntryOrGuidAndSourceType.entryOrGuid.ToString(), sourceSet);
            richTextBoxSqlOutput.Text = richTextBoxSqlOutput.Text.Replace("SET " + sourceSet + " := " + sourceSet, "SET " + sourceSet + " := " + originalEntryOrGuidAndSourceType.entryOrGuid.ToString());

            //! Replaces '@ENTRY*100[id]' ([id] being like 00, 01, 02, 03, etc.) by '@ENTRY*100+3' for example.
            for (int i = 0; i < 50; ++i) //! We expect a maximum of 50 scripts for one entry...
                richTextBoxSqlOutput.Text = richTextBoxSqlOutput.Text.Replace(sourceSet + "0" + i.ToString(), sourceSet + "*100+" + i.ToString());

            //! Replaces '@ENTRY*100+0' by just '@ENTRY*100' (which is proper codestyle)
            richTextBoxSqlOutput.Text = richTextBoxSqlOutput.Text.Replace(sourceSet + "*100+0", sourceSet + "*100");
        }

        private async void buttonExecuteScript_Click(object sender, EventArgs e)
        {
            string revertQuery = String.Empty;

            if (Settings.Default.CreateRevertQuery)
                revertQuery = await InitializeRevertQuery();

            if (await SAI_Editor_Manager.Instance.worldDatabase.ExecuteNonQuery(richTextBoxSqlOutput.Text))
            {
                MessageBox.Show("The query has been executed succesfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Settings.Default.CreateRevertQuery)
                    CreateRevertQuery(revertQuery);
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*";
            saveFileDialog.ShowDialog(this);
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBoxSqlOutput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("The file has been saved succesfully! Do you want to open it?", "Success!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                StartProcess(saveFileDialog.FileName);
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

        private void SqlOutputForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private async Task<string> InitializeRevertQuery()
        {
            string revertQuery = String.Empty;
            List<EntryOrGuidAndSourceType> entriesOrGuidsAndSourceTypes = GetUniqueEntriesOrGuidsAndSourceTypes();

            foreach (EntryOrGuidAndSourceType entryOrGuidAndSourceType in entriesOrGuidsAndSourceTypes)
            {
                List<SmartScript> smartScripts = await SAI_Editor_Manager.Instance.worldDatabase.GetSmartScripts(entryOrGuidAndSourceType.entryOrGuid, (int)entryOrGuidAndSourceType.sourceType);

                if (smartScripts == null || smartScripts.Count == 0)
                    continue;

                for (int i = 0; i < smartScripts.Count; ++i)
                {
                    SmartScript smartScript = smartScripts[i];

                    if (i > 0)
                        revertQuery += "\n";

                    revertQuery += "UPDATE smart_scripts SET ";
                    revertQuery += String.Format("event_type={0},event_phase_mask={1},event_chance={2},event_flags={3},", smartScript.event_type, smartScript.event_phase_mask, smartScript.event_chance, smartScript.event_flags);
                    revertQuery += String.Format("event_param1={0},event_param2={1},event_param3={2},event_param4={3},", smartScript.event_param1, smartScript.event_param2, smartScript.event_param3, smartScript.event_param4);
                    revertQuery += String.Format("action_type={0},action_param1={1},action_param2={2},action_param3={3},", smartScript.action_type, smartScript.action_param1, smartScript.action_param2, smartScript.action_param3);
                    revertQuery += String.Format("action_param4={0},action_param5={1},action_param6={2},target_type={3},", smartScript.action_param4, smartScript.action_param5, smartScript.action_param6, smartScript.target_type);
                    revertQuery += String.Format("target_param1={0},target_param2={1},target_param3={2},target_x={3},", smartScript.target_param1, smartScript.target_param2, smartScript.target_param3, smartScript.target_x);
                    revertQuery += String.Format("target_y={0},target_z={1},target_o={2},comment=" + '"' + "{3}" + '"', smartScript.target_y, smartScript.target_z, smartScript.target_o, smartScript.comment);
                    revertQuery += String.Format(" WHERE entryorguid={0} AND source_type={1} AND id={2};", smartScript.entryorguid, smartScript.source_type, smartScript.id);
                }
            }

            return revertQuery;
        }

        private void CreateRevertQuery(string revertQuery)
        {
            //! Example output:
            //! [Creature][33303] 3-10-2013 15.32.40.sql
            string filename = @"Reverts\[" + GetSourceTypeString(originalEntryOrGuidAndSourceType.sourceType) + "] [" + originalEntryOrGuidAndSourceType.entryOrGuid + "] " + DateTime.Now.ToString() + ".sql";

            if (!Directory.Exists("Reverts"))
                Directory.CreateDirectory("Reverts");

            filename = filename.Replace(":", ";");
            File.WriteAllText(filename, revertQuery);
        }

        private string GetSourceTypeString(SourceTypes sourceType)
        {
            switch (sourceType)
            {
                case SourceTypes.SourceTypeCreature:
                    return "Creature";
                case SourceTypes.SourceTypeGameobject:
                    return "Gameobject";
                case SourceTypes.SourceTypeAreaTrigger:
                    return "Areatrigger";
                case SourceTypes.SourceTypeScriptedActionlist:
                    return "Actionlist";
                default:
                    return "Unknown";
            }
        }
    }
}
