using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAM_use.Properties;

namespace RAM_use
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        public void warning80_Load(object sender, EventArgs e)
        {
            labelPercent.Text = ($"RAM {Settings.Default["WarningValue"].ToString()}%");
            labelPercent.Parent = button1;
            labelPercent.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void labelPercent_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
