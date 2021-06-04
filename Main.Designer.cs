namespace save_loads_ui
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labOutputPath = new System.Windows.Forms.Label();
            this.boxOutputPath = new System.Windows.Forms.TextBox();
            this.butOutputPath = new System.Windows.Forms.Button();
            this.tOptions = new System.Windows.Forms.TableLayoutPanel();
            this.labPrefix = new System.Windows.Forms.Label();
            this.boxPrefix = new System.Windows.Forms.TextBox();
            this.labNaming = new System.Windows.Forms.Label();
            this.boxNumSegments = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.labLoadTime = new System.Windows.Forms.Label();
            this.labNumSegments = new System.Windows.Forms.Label();
            this.boxLoadTime = new System.Windows.Forms.NumericUpDown();
            this.boxStartFrom = new System.Windows.Forms.NumericUpDown();
            this.chkMakeFiles = new System.Windows.Forms.CheckBox();
            this.chkVoidclipEnable = new System.Windows.Forms.CheckBox();
            this.gAdditionalCommands = new System.Windows.Forms.GroupBox();
            this.labAdditionalCommandsNote = new System.Windows.Forms.Label();
            this.boxAdditionalCommands = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.boxWaitTime = new System.Windows.Forms.NumericUpDown();
            this.labWaitTime = new System.Windows.Forms.Label();
            this.labWaitTimeNote = new System.Windows.Forms.Label();
            this.gVoidclips = new System.Windows.Forms.GroupBox();
            this.butExecute = new System.Windows.Forms.Button();
            this.labNote = new System.Windows.Forms.Label();
            this.butOpenScript = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labSaveCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butAdvanced = new System.Windows.Forms.Button();
            this.tOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxNumSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLoadTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxStartFrom)).BeginInit();
            this.gAdditionalCommands.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxWaitTime)).BeginInit();
            this.gVoidclips.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labOutputPath
            // 
            this.labOutputPath.AutoSize = true;
            this.labOutputPath.Location = new System.Drawing.Point(15, 13);
            this.labOutputPath.Name = "labOutputPath";
            this.labOutputPath.Size = new System.Drawing.Size(39, 13);
            this.labOutputPath.TabIndex = 0;
            this.labOutputPath.Text = "Output";
            // 
            // boxOutputPath
            // 
            this.boxOutputPath.Location = new System.Drawing.Point(64, 10);
            this.boxOutputPath.Name = "boxOutputPath";
            this.boxOutputPath.Size = new System.Drawing.Size(251, 20);
            this.boxOutputPath.TabIndex = 1;
            // 
            // butOutputPath
            // 
            this.butOutputPath.Location = new System.Drawing.Point(321, 9);
            this.butOutputPath.Name = "butOutputPath";
            this.butOutputPath.Size = new System.Drawing.Size(75, 23);
            this.butOutputPath.TabIndex = 2;
            this.butOutputPath.Text = "Browse";
            this.butOutputPath.UseVisualStyleBackColor = true;
            this.butOutputPath.Click += new System.EventHandler(this.butOutputPath_Click);
            // 
            // tOptions
            // 
            this.tOptions.ColumnCount = 2;
            this.tOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tOptions.Controls.Add(this.labPrefix, 0, 0);
            this.tOptions.Controls.Add(this.boxPrefix, 1, 0);
            this.tOptions.Controls.Add(this.labNaming, 1, 1);
            this.tOptions.Location = new System.Drawing.Point(12, 36);
            this.tOptions.Name = "tOptions";
            this.tOptions.RowCount = 2;
            this.tOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tOptions.Size = new System.Drawing.Size(384, 50);
            this.tOptions.TabIndex = 3;
            // 
            // labPrefix
            // 
            this.labPrefix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labPrefix.AutoSize = true;
            this.labPrefix.Location = new System.Drawing.Point(3, 6);
            this.labPrefix.Name = "labPrefix";
            this.labPrefix.Size = new System.Drawing.Size(33, 13);
            this.labPrefix.TabIndex = 0;
            this.labPrefix.Text = "Prefix";
            // 
            // boxPrefix
            // 
            this.boxPrefix.Location = new System.Drawing.Point(105, 3);
            this.boxPrefix.Name = "boxPrefix";
            this.boxPrefix.Size = new System.Drawing.Size(198, 20);
            this.boxPrefix.TabIndex = 4;
            // 
            // labNaming
            // 
            this.labNaming.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labNaming.AutoSize = true;
            this.labNaming.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labNaming.Location = new System.Drawing.Point(105, 31);
            this.labNaming.Name = "labNaming";
            this.labNaming.Size = new System.Drawing.Size(240, 13);
            this.labNaming.TabIndex = 8;
            this.labNaming.Text = "Saves and Demo naming will be <prefix>-<count>";
            // 
            // boxNumSegments
            // 
            this.boxNumSegments.Location = new System.Drawing.Point(98, 28);
            this.boxNumSegments.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.boxNumSegments.Name = "boxNumSegments";
            this.boxNumSegments.Size = new System.Drawing.Size(49, 20);
            this.boxNumSegments.TabIndex = 10;
            this.boxNumSegments.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.boxNumSegments.ValueChanged += new System.EventHandler(this.boxNumSegments_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Start from Save #";
            // 
            // labLoadTime
            // 
            this.labLoadTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labLoadTime.AutoSize = true;
            this.labLoadTime.Location = new System.Drawing.Point(3, 56);
            this.labLoadTime.Name = "labLoadTime";
            this.labLoadTime.Size = new System.Drawing.Size(57, 13);
            this.labLoadTime.TabIndex = 2;
            this.labLoadTime.Text = "Load Time";
            // 
            // labNumSegments
            // 
            this.labNumSegments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labNumSegments.AutoSize = true;
            this.labNumSegments.Location = new System.Drawing.Point(3, 31);
            this.labNumSegments.Name = "labNumSegments";
            this.labNumSegments.Size = new System.Drawing.Size(71, 13);
            this.labNumSegments.TabIndex = 1;
            this.labNumSegments.Text = "Up to Save #";
            // 
            // boxLoadTime
            // 
            this.boxLoadTime.Location = new System.Drawing.Point(98, 53);
            this.boxLoadTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.boxLoadTime.Name = "boxLoadTime";
            this.boxLoadTime.Size = new System.Drawing.Size(49, 20);
            this.boxLoadTime.TabIndex = 11;
            this.boxLoadTime.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // boxStartFrom
            // 
            this.boxStartFrom.Location = new System.Drawing.Point(98, 3);
            this.boxStartFrom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.boxStartFrom.Name = "boxStartFrom";
            this.boxStartFrom.Size = new System.Drawing.Size(49, 20);
            this.boxStartFrom.TabIndex = 12;
            this.boxStartFrom.ValueChanged += new System.EventHandler(this.boxStartFrom_ValueChanged);
            // 
            // chkMakeFiles
            // 
            this.chkMakeFiles.AutoSize = true;
            this.chkMakeFiles.Checked = true;
            this.chkMakeFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMakeFiles.Location = new System.Drawing.Point(13, 100);
            this.chkMakeFiles.Name = "chkMakeFiles";
            this.chkMakeFiles.Size = new System.Drawing.Size(143, 17);
            this.chkMakeFiles.TabIndex = 4;
            this.chkMakeFiles.Text = "Make Saves and Demos";
            this.chkMakeFiles.UseVisualStyleBackColor = true;
            // 
            // chkVoidclipEnable
            // 
            this.chkVoidclipEnable.AutoSize = true;
            this.chkVoidclipEnable.Location = new System.Drawing.Point(13, 22);
            this.chkVoidclipEnable.Name = "chkVoidclipEnable";
            this.chkVoidclipEnable.Size = new System.Drawing.Size(65, 17);
            this.chkVoidclipEnable.TabIndex = 5;
            this.chkVoidclipEnable.Text = "Enabled";
            this.chkVoidclipEnable.UseVisualStyleBackColor = true;
            this.chkVoidclipEnable.CheckedChanged += new System.EventHandler(this.chkVoidclipEnable_CheckedChanged);
            // 
            // gAdditionalCommands
            // 
            this.gAdditionalCommands.Controls.Add(this.labAdditionalCommandsNote);
            this.gAdditionalCommands.Controls.Add(this.boxAdditionalCommands);
            this.gAdditionalCommands.Location = new System.Drawing.Point(12, 305);
            this.gAdditionalCommands.Name = "gAdditionalCommands";
            this.gAdditionalCommands.Size = new System.Drawing.Size(384, 104);
            this.gAdditionalCommands.TabIndex = 6;
            this.gAdditionalCommands.TabStop = false;
            this.gAdditionalCommands.Text = "Commands to execute every Save/Load";
            // 
            // labAdditionalCommandsNote
            // 
            this.labAdditionalCommandsNote.AutoSize = true;
            this.labAdditionalCommandsNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labAdditionalCommandsNote.Location = new System.Drawing.Point(4, 83);
            this.labAdditionalCommandsNote.Name = "labAdditionalCommandsNote";
            this.labAdditionalCommandsNote.Size = new System.Drawing.Size(86, 13);
            this.labAdditionalCommandsNote.TabIndex = 1;
            this.labAdditionalCommandsNote.Text = "(spaces allowed)";
            // 
            // boxAdditionalCommands
            // 
            this.boxAdditionalCommands.Location = new System.Drawing.Point(7, 20);
            this.boxAdditionalCommands.Multiline = true;
            this.boxAdditionalCommands.Name = "boxAdditionalCommands";
            this.boxAdditionalCommands.Size = new System.Drawing.Size(371, 60);
            this.boxAdditionalCommands.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel2.Controls.Add(this.boxWaitTime, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labWaitTime, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labWaitTimeNote, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 25);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // boxWaitTime
            // 
            this.boxWaitTime.Location = new System.Drawing.Point(98, 3);
            this.boxWaitTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.boxWaitTime.Name = "boxWaitTime";
            this.boxWaitTime.Size = new System.Drawing.Size(49, 20);
            this.boxWaitTime.TabIndex = 11;
            this.boxWaitTime.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labWaitTime
            // 
            this.labWaitTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labWaitTime.AutoSize = true;
            this.labWaitTime.Location = new System.Drawing.Point(3, 6);
            this.labWaitTime.Name = "labWaitTime";
            this.labWaitTime.Size = new System.Drawing.Size(55, 13);
            this.labWaitTime.TabIndex = 1;
            this.labWaitTime.Text = "Wait Time";
            // 
            // labWaitTimeNote
            // 
            this.labWaitTimeNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labWaitTimeNote.AutoSize = true;
            this.labWaitTimeNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labWaitTimeNote.Location = new System.Drawing.Point(160, 6);
            this.labWaitTimeNote.Name = "labWaitTimeNote";
            this.labWaitTimeNote.Size = new System.Drawing.Size(188, 13);
            this.labWaitTimeNote.TabIndex = 9;
            this.labWaitTimeNote.Text = "(before unpausing and screenshotting)";
            // 
            // gVoidclips
            // 
            this.gVoidclips.Controls.Add(this.chkVoidclipEnable);
            this.gVoidclips.Controls.Add(this.tableLayoutPanel2);
            this.gVoidclips.Location = new System.Drawing.Point(12, 222);
            this.gVoidclips.Name = "gVoidclips";
            this.gVoidclips.Size = new System.Drawing.Size(384, 77);
            this.gVoidclips.TabIndex = 10;
            this.gVoidclips.TabStop = false;
            this.gVoidclips.Text = "Rendering Voidclips (will only load saves and take screenshots)";
            // 
            // butExecute
            // 
            this.butExecute.Location = new System.Drawing.Point(321, 415);
            this.butExecute.Name = "butExecute";
            this.butExecute.Size = new System.Drawing.Size(75, 23);
            this.butExecute.TabIndex = 11;
            this.butExecute.Text = "Generate";
            this.butExecute.UseVisualStyleBackColor = true;
            this.butExecute.Click += new System.EventHandler(this.butExecute_Click);
            // 
            // labNote
            // 
            this.labNote.AutoSize = true;
            this.labNote.Location = new System.Drawing.Point(9, 420);
            this.labNote.Name = "labNote";
            this.labNote.Size = new System.Drawing.Size(101, 13);
            this.labNote.TabIndex = 12;
            this.labNote.Text = "by 2838 - May 2021";
            // 
            // butOpenScript
            // 
            this.butOpenScript.Location = new System.Drawing.Point(240, 415);
            this.butOpenScript.Name = "butOpenScript";
            this.butOpenScript.Size = new System.Drawing.Size(75, 23);
            this.butOpenScript.TabIndex = 13;
            this.butOpenScript.Text = "Open Script";
            this.butOpenScript.UseVisualStyleBackColor = true;
            this.butOpenScript.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel1.Controls.Add(this.labLoadTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.boxLoadTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labNumSegments, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.boxStartFrom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.boxNumSegments, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labSaveCount, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 75);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // labSaveCount
            // 
            this.labSaveCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSaveCount.AutoSize = true;
            this.labSaveCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labSaveCount.Location = new System.Drawing.Point(154, 31);
            this.labSaveCount.Name = "labSaveCount";
            this.labSaveCount.Size = new System.Drawing.Size(140, 13);
            this.labSaveCount.TabIndex = 13;
            this.labSaveCount.Text = "(there will be 0 Save/Loads)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butAdvanced);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.chkMakeFiles);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 124);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Making Voidclips";
            // 
            // butAdvanced
            // 
            this.butAdvanced.Location = new System.Drawing.Point(303, 94);
            this.butAdvanced.Name = "butAdvanced";
            this.butAdvanced.Size = new System.Drawing.Size(75, 23);
            this.butAdvanced.TabIndex = 13;
            this.butAdvanced.Text = "Advanced";
            this.butAdvanced.UseVisualStyleBackColor = true;
            this.butAdvanced.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butOpenScript);
            this.Controls.Add(this.labNote);
            this.Controls.Add(this.butExecute);
            this.Controls.Add(this.gVoidclips);
            this.Controls.Add(this.gAdditionalCommands);
            this.Controls.Add(this.tOptions);
            this.Controls.Add(this.butOutputPath);
            this.Controls.Add(this.boxOutputPath);
            this.Controls.Add(this.labOutputPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(424, 493);
            this.Name = "Main";
            this.Text = "Voidclipping Script Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.Load += new System.EventHandler(this.LoadSettings);
            this.tOptions.ResumeLayout(false);
            this.tOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxNumSegments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLoadTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxStartFrom)).EndInit();
            this.gAdditionalCommands.ResumeLayout(false);
            this.gAdditionalCommands.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxWaitTime)).EndInit();
            this.gVoidclips.ResumeLayout(false);
            this.gVoidclips.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labOutputPath;
        private System.Windows.Forms.TextBox boxOutputPath;
        private System.Windows.Forms.Button butOutputPath;
        private System.Windows.Forms.TableLayoutPanel tOptions;
        private System.Windows.Forms.Label labPrefix;
        private System.Windows.Forms.Label labNumSegments;
        private System.Windows.Forms.Label labLoadTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkMakeFiles;
        private System.Windows.Forms.TextBox boxPrefix;
        private System.Windows.Forms.Label labNaming;
        private System.Windows.Forms.CheckBox chkVoidclipEnable;
        private System.Windows.Forms.GroupBox gAdditionalCommands;
        private System.Windows.Forms.TextBox boxAdditionalCommands;
        private System.Windows.Forms.Label labAdditionalCommandsNote;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labWaitTime;
        private System.Windows.Forms.Label labWaitTimeNote;
        private System.Windows.Forms.GroupBox gVoidclips;
        private System.Windows.Forms.NumericUpDown boxNumSegments;
        private System.Windows.Forms.NumericUpDown boxLoadTime;
        private System.Windows.Forms.NumericUpDown boxStartFrom;
        private System.Windows.Forms.NumericUpDown boxWaitTime;
        private System.Windows.Forms.Button butExecute;
        private System.Windows.Forms.Label labNote;
        private System.Windows.Forms.Button butOpenScript;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butAdvanced;
        private System.Windows.Forms.Label labSaveCount;
    }
}

