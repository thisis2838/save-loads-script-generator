using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace save_loads_ui
{
    public partial class Advanced : Form
    {
        private const string _doAliasDef = "reload;{additional_commands};_y_spt_afterframes {load_time} {save_current};wait 10;{record_command}";
        private const string _saveAliasDef = "{additional_commands};{save_command};unpause;echo #SAVE#;wait 100;{stop};wait 10;{do_next}";

        public Advanced()
        {
            InitializeComponent();
        }
        public string GetDoAlias()
        {
            return boxDoAlias.Text;
        }

        public string GetSaveAlias()
        {
            return boxSaveAlias.Text;
        }

        public void LoadSettings(object sender, EventArgs e)
        {
            boxDoAlias.Text = Properties.Settings.Default.DoAlias;
            boxSaveAlias.Text = Properties.Settings.Default.SaveAlias;
        }

        public void SaveSettings(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.DoAlias = boxDoAlias.Text;
            Properties.Settings.Default.SaveAlias = boxSaveAlias.Text;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Advanced_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxDoAlias.Text = _doAliasDef;
            boxSaveAlias.Text = _saveAliasDef;
        }
    }
}
