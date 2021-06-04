namespace save_loads_ui
{
    partial class Advanced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advanced));
            this.gSaveAlias = new System.Windows.Forms.GroupBox();
            this.boxSaveAlias = new System.Windows.Forms.TextBox();
            this.gDoAlias = new System.Windows.Forms.GroupBox();
            this.boxDoAlias = new System.Windows.Forms.TextBox();
            this.gTagGuide = new System.Windows.Forms.GroupBox();
            this.tTagGuide = new System.Windows.Forms.TableLayoutPanel();
            this.labTags = new System.Windows.Forms.Label();
            this.labTagDesc = new System.Windows.Forms.Label();
            this.gExecOrder = new System.Windows.Forms.GroupBox();
            this.labExecOrder = new System.Windows.Forms.Label();
            this.butReset = new System.Windows.Forms.Button();
            this.gSaveAlias.SuspendLayout();
            this.gDoAlias.SuspendLayout();
            this.gTagGuide.SuspendLayout();
            this.tTagGuide.SuspendLayout();
            this.gExecOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gSaveAlias
            // 
            this.gSaveAlias.Controls.Add(this.boxSaveAlias);
            this.gSaveAlias.Location = new System.Drawing.Point(12, 12);
            this.gSaveAlias.Name = "gSaveAlias";
            this.gSaveAlias.Size = new System.Drawing.Size(384, 90);
            this.gSaveAlias.TabIndex = 0;
            this.gSaveAlias.TabStop = false;
            this.gSaveAlias.Text = "save Alias";
            // 
            // boxSaveAlias
            // 
            this.boxSaveAlias.Location = new System.Drawing.Point(7, 20);
            this.boxSaveAlias.Multiline = true;
            this.boxSaveAlias.Name = "boxSaveAlias";
            this.boxSaveAlias.Size = new System.Drawing.Size(371, 60);
            this.boxSaveAlias.TabIndex = 0;
            // 
            // gDoAlias
            // 
            this.gDoAlias.Controls.Add(this.boxDoAlias);
            this.gDoAlias.Location = new System.Drawing.Point(12, 108);
            this.gDoAlias.Name = "gDoAlias";
            this.gDoAlias.Size = new System.Drawing.Size(384, 90);
            this.gDoAlias.TabIndex = 1;
            this.gDoAlias.TabStop = false;
            this.gDoAlias.Text = "do Alias";
            // 
            // boxDoAlias
            // 
            this.boxDoAlias.Location = new System.Drawing.Point(6, 19);
            this.boxDoAlias.Multiline = true;
            this.boxDoAlias.Name = "boxDoAlias";
            this.boxDoAlias.Size = new System.Drawing.Size(371, 60);
            this.boxDoAlias.TabIndex = 1;
            // 
            // gTagGuide
            // 
            this.gTagGuide.Controls.Add(this.tTagGuide);
            this.gTagGuide.Location = new System.Drawing.Point(12, 233);
            this.gTagGuide.Name = "gTagGuide";
            this.gTagGuide.Size = new System.Drawing.Size(384, 179);
            this.gTagGuide.TabIndex = 2;
            this.gTagGuide.TabStop = false;
            this.gTagGuide.Text = "Tag Guide";
            // 
            // tTagGuide
            // 
            this.tTagGuide.ColumnCount = 2;
            this.tTagGuide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tTagGuide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tTagGuide.Controls.Add(this.labTags, 0, 0);
            this.tTagGuide.Controls.Add(this.labTagDesc, 1, 0);
            this.tTagGuide.Location = new System.Drawing.Point(7, 20);
            this.tTagGuide.Name = "tTagGuide";
            this.tTagGuide.RowCount = 1;
            this.tTagGuide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tTagGuide.Size = new System.Drawing.Size(370, 150);
            this.tTagGuide.TabIndex = 0;
            // 
            // labTags
            // 
            this.labTags.AutoSize = true;
            this.labTags.Location = new System.Drawing.Point(3, 0);
            this.labTags.Name = "labTags";
            this.labTags.Size = new System.Drawing.Size(117, 143);
            this.labTags.TabIndex = 0;
            this.labTags.Text = "{do_next}\r\n{do_current}\r\n{save_next}\r\n{save_current}\r\n{save_command}\r\n{record_com" +
    "mand}\r\n{load_time}\r\n{stop}\r\n\r\n\r\n{additional_commands}";
            // 
            // labTagDesc
            // 
            this.labTagDesc.AutoSize = true;
            this.labTagDesc.Location = new System.Drawing.Point(131, 0);
            this.labTagDesc.Name = "labTagDesc";
            this.labTagDesc.Size = new System.Drawing.Size(217, 143);
            this.labTagDesc.TabIndex = 1;
            this.labTagDesc.Text = resources.GetString("labTagDesc.Text");
            // 
            // gExecOrder
            // 
            this.gExecOrder.Controls.Add(this.labExecOrder);
            this.gExecOrder.Location = new System.Drawing.Point(12, 418);
            this.gExecOrder.Name = "gExecOrder";
            this.gExecOrder.Size = new System.Drawing.Size(384, 64);
            this.gExecOrder.TabIndex = 3;
            this.gExecOrder.TabStop = false;
            this.gExecOrder.Text = "Execution Order";
            // 
            // labExecOrder
            // 
            this.labExecOrder.AutoSize = true;
            this.labExecOrder.Location = new System.Drawing.Point(6, 16);
            this.labExecOrder.Name = "labExecOrder";
            this.labExecOrder.Size = new System.Drawing.Size(375, 39);
            this.labExecOrder.TabIndex = 0;
            this.labExecOrder.Text = resources.GetString("labExecOrder.Text");
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(295, 204);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(101, 23);
            this.butReset.TabIndex = 1;
            this.butReset.Text = "Reset to Defaults";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 500);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.gExecOrder);
            this.Controls.Add(this.gTagGuide);
            this.Controls.Add(this.gDoAlias);
            this.Controls.Add(this.gSaveAlias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(424, 539);
            this.Name = "Advanced";
            this.Text = "Alias Formatting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Advanced_FormClosing);
            this.Load += new System.EventHandler(this.LoadSettings);
            this.gSaveAlias.ResumeLayout(false);
            this.gSaveAlias.PerformLayout();
            this.gDoAlias.ResumeLayout(false);
            this.gDoAlias.PerformLayout();
            this.gTagGuide.ResumeLayout(false);
            this.tTagGuide.ResumeLayout(false);
            this.tTagGuide.PerformLayout();
            this.gExecOrder.ResumeLayout(false);
            this.gExecOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gSaveAlias;
        private System.Windows.Forms.TextBox boxSaveAlias;
        private System.Windows.Forms.GroupBox gDoAlias;
        private System.Windows.Forms.TextBox boxDoAlias;
        private System.Windows.Forms.GroupBox gTagGuide;
        private System.Windows.Forms.TableLayoutPanel tTagGuide;
        private System.Windows.Forms.Label labTags;
        private System.Windows.Forms.Label labTagDesc;
        private System.Windows.Forms.GroupBox gExecOrder;
        private System.Windows.Forms.Label labExecOrder;
        private System.Windows.Forms.Button butReset;
    }
}