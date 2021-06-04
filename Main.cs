using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace save_loads_ui
{
    public partial class Main : Form
    {
        private Advanced _advanced;

        public Main()
        {
            InitializeComponent();
            _advanced = new Advanced();
        }

        private void butExecute_Click(object sender, EventArgs e)
        {
            if (boxOutputPath.Text == "" ||
                !Directory.Exists(Path.GetDirectoryName(boxOutputPath.Text)))
            {
                MessageBox.Show("Output Folder invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkVoidclipEnable.Checked)
                DoScreenshotScript();
            else DoNormalScript();

            SystemSounds.Asterisk.Play();
            labNote.Text = $"[{DateTime.Now}] Generated script!";
            labNote.Invalidate();
        }

        private void DoNormalScript()
        {
            int numSaves = (int)boxNumSegments.Value;
            int startFrom = (int)boxStartFrom.Value;
            int loadTime = (int)boxLoadTime.Value;
            string commands = boxAdditionalCommands.Text;
            string prefix = boxPrefix.Text + "-";
            bool doSeg = chkMakeFiles.Checked;

            string saveAlias = _advanced.GetSaveAlias();
            string doAlias = _advanced.GetDoAlias();

            StringBuilder script = new StringBuilder();

            script.AppendLine("// AUTO-GENERATED SCRIPT -- PRESS P TO STOP THE SCRIPT MID-PROCESS!!");
            script.AppendLine($"// {numSaves} saves, starting from save #{startFrom}, load time {loadTime}, prefix \"{prefix}\"");
            script.AppendLine($"// commands executed every do/save alias: \"{commands}\"");
            if (!doSeg)
                script.AppendLine("// not creating unique demos and saves for each segment, only a dummy \"foo\" save file will be made");
            script.AppendLine("\n");
            script.AppendLine("_y_spt_afterframes_reset_on_server_activate 0;bind p \"_y_spt_afterframes_reset_on_server_activate 1; stop\"");
            script.AppendLine("\n");

            string saveName, saveCommand, recCommand, stop;
            int i;

            string ReplaceTags(string s)
            {
                return s.Replace("{do_next}", $"do{i + 1:000}")
                        .Replace("{do_current}", $"do{i:000}")
                        .Replace("{save_next}", $"save{i + 1:000}")
                        .Replace("{save_current}", $"save{i:000}")
                        .Replace("{save_command}", saveCommand)
                        .Replace("{record_command}", recCommand)
                        .Replace("{load_time}", loadTime.ToString())
                        .Replace("{stop}", stop)
                        .Replace("{additional_commands}", commands);
            }

            for (i = startFrom; i <= numSaves; i++)
            {
                saveName = prefix + i.ToString("000");
                saveCommand = (doSeg) ? "save " + saveName : "save foo";
                recCommand = (doSeg) ? "record " + saveName : "";
                stop = (doSeg) ? "stop" : "";

                //string aliasSave = string.Format($"alias save{i:000} \"{command}{saveCommand};unpause;echo #SAVE#;wait 100;{stop}wait 10;do{(i + 1):000}\"");
                //string aliasLoad = string.Format($"alias do{i:000} \"reload;{command}_y_spt_afterframes {loadTime} save{i:000};wait 10;{recCommand}\"");

                string aliasSave = $"alias save{i:000} " + $"\"{ReplaceTags(saveAlias)}\"";
                string aliasLoad = $"alias do{i:000} " + $"\"{ReplaceTags(doAlias)}\"";

                script.AppendLine(aliasSave.Replace(";;", ";")); //cleanup
                script.AppendLine(aliasLoad.Replace(";;", ";"));
            }

            script.AppendLine($"alias do{numSaves + 1:000}");
            script.AppendLine($"do{startFrom:000}");
            Write(new string[] { script.ToString() });
        }

        /*
        private void DoNormalScript()
        {
            int numSaves = (int)boxNumSegments.Value;
            int startFrom = (int)boxStartFrom.Value;
            int loadTime = (int)boxLoadTime.Value;
            string commands = boxAdditionalCommands.Text;
            string prefix = boxPrefix.Text + "-";
            bool doSeg = chkMakeFiles.Checked;

            StringBuilder script = new StringBuilder();

            script.AppendLine("// AUTO-GENERATED SCRIPT -- PRESS P TO STOP THE VOIDCLIP MID-PROCESS!!");
            script.AppendLine($"// {numSaves} saves, starting from save #{startFrom}, load time {loadTime}, prefix \"{prefix}\"");
            script.AppendLine($"// commands \"{commands}\"");
            script.AppendLine("\n");
            script.AppendLine("_y_spt_afterframes_reset_on_server_activate 0;bind p \"_y_spt_afterframes_reset_on_server_activate 1; stop\"");
            script.AppendLine("\n");

            for (int i = startFrom; i <= numSaves; i++)
            {
                string saveName = prefix + i.ToString("000");
                string saveCommand = (doSeg) ? "save " + saveName : "save foo";
                string recCommand = (doSeg) ? "record " + saveName : "";
                string stop = (doSeg) ? "stop;" : "";

                string command = commands == "" ? "" : commands + ";";

                string aliasSave = string.Format($"alias save{i:000} \"{command}{saveCommand};unpause;echo #SAVE#;wait 100;{stop}wait 10;do{(i + 1):000}\"");
                string aliasLoad = string.Format($"alias do{i:000} \"reload;{command}_y_spt_afterframes {loadTime} save{i:000};wait 10;{recCommand}\"");

                script.AppendLine(aliasSave);
                script.AppendLine(aliasLoad);
            }

            script.AppendLine($"alias do{numSaves + 1:000}");
            script.AppendLine($"do{startFrom:000}");
            Write(new string[] { script.ToString() });
        }
        */

        public void DoScreenshotScript()
        {
            int numSaves = (int)boxNumSegments.Value;
            int startFrom = (int)boxStartFrom.Value;
            int waitTime = (int)boxWaitTime.Value;
            string prefix = boxPrefix.Text + "-";

            StringBuilder script = new StringBuilder();

            script.AppendLine("// AUTO-GENERATED SCRIPT -- PRESS P TO STOP THE SCRIPT MID-PROCESS!!");
            script.AppendLine($"// screenshotting {numSaves} segs, prefix \"{prefix}\"");
            script.AppendLine("\n");
            script.AppendLine("_y_spt_afterframes_reset_on_server_activate 0;bind p \"_y_spt_afterframes_reset_on_server_activate 1; stop\"");
            script.AppendLine("\n");

            for (int i = startFrom; i <= numSaves; i++)
            {
                string saveName = prefix + i.ToString("000");
                string alias = $"alias do{i:000} \"load {saveName};wait 100 \"\"unpause; wait {waitTime}; screenshot;wait 10;do{(i + 1):000}\"\"\"";
                script.AppendLine(alias);
            }

            script.AppendLine($"alias do{numSaves + 1:000}");
            script.AppendLine($"do{startFrom:000}");

            Write(new string[] { script.ToString() });
        }

        public void Write(string[] content)
        {
            File.WriteAllLines(boxOutputPath.Text, content);
        }

        private void butOutputPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Config Files (*.cfg)|*.cfg";
            dialog.DefaultExt = "cfg";
            dialog.AddExtension = true;

            if (dialog.ShowDialog() == DialogResult.OK)
                boxOutputPath.Text = dialog.FileName;
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            _advanced.LoadSettings(sender, null);

            boxOutputPath.Text = Properties.Settings.Default.OutputPath;
            boxPrefix.Text = Properties.Settings.Default.Prefix;
            boxLoadTime.Value = Properties.Settings.Default.LoadTime;
            boxStartFrom.Value = Properties.Settings.Default.StartFrom;
            boxNumSegments.Value = Properties.Settings.Default.NumSegments;
            chkMakeFiles.Checked = Properties.Settings.Default.MakeFiles;

            chkVoidclipEnable.Checked = Properties.Settings.Default.VoidclipEnable;
            boxWaitTime.Value = Properties.Settings.Default.WaitTime;

            boxAdditionalCommands.Text = Properties.Settings.Default.AdditionalCommands;

            chkVoidclipEnable_CheckedChanged(this, null);
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            _advanced.SaveSettings(sender, null);

            Properties.Settings.Default.OutputPath = boxOutputPath.Text;
            Properties.Settings.Default.Prefix = boxPrefix.Text;
            Properties.Settings.Default.LoadTime = (int)boxLoadTime.Value;
            Properties.Settings.Default.StartFrom = (int)boxStartFrom.Value;
            Properties.Settings.Default.NumSegments = (int)boxNumSegments.Value;
            Properties.Settings.Default.MakeFiles = chkMakeFiles.Checked;

            Properties.Settings.Default.VoidclipEnable = chkVoidclipEnable.Checked;
            Properties.Settings.Default.WaitTime = (int)boxWaitTime.Value;

            Properties.Settings.Default.AdditionalCommands = boxAdditionalCommands.Text;

            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(boxOutputPath.Text))
                return;

            try
            {
                Process.Start(boxOutputPath.Text);
            }
            catch
            {
                Process.Start("notepad.exe", boxOutputPath.Text);
            }
        }

        private void chkVoidclipEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVoidclipEnable.Checked)
            {
                boxLoadTime.Enabled = false;
                chkMakeFiles.Enabled = false;
                butAdvanced.Enabled = false;

                boxWaitTime.Enabled = true;
            }
            else
            {
                boxLoadTime.Enabled = true;
                chkMakeFiles.Enabled = true;
                butAdvanced.Enabled = true;

                boxWaitTime.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _advanced.Show();
        }

        private void UpdateSaveCount()
        {
            int count = (int)(boxNumSegments.Value - boxStartFrom.Value + 1);
            count = count <= 0 ? 0 : count;

            labSaveCount.Text = $"(there will be {count} Save/Loads)";
        }

        private void boxStartFrom_ValueChanged(object sender, EventArgs e)
        {
            UpdateSaveCount();
        }

        private void boxNumSegments_ValueChanged(object sender, EventArgs e)
        {
            UpdateSaveCount();
        }
    }
}
