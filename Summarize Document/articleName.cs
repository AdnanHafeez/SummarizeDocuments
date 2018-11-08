using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summarize_Document
{
    public partial class articleName : Form
    {
        public string articlename;
        public articleName()
        {
            InitializeComponent();
        }

        private void wikiName_TextChanged(object sender, EventArgs e)
        {
            if(wikiName.Text.Length > 0)
            {
                OK.Enabled = true;
            }
            else
            {
                OK.Enabled = false;
            }
        }

        private void articleName_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void articleName_FormClosing(object sender, FormClosingEventArgs e)
        {
            articlename = wikiName.Text;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            articlename = wikiName.Text;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            articlename = "";
            this.Close();
        }
    }
}
