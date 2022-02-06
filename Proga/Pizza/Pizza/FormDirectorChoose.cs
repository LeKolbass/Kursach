using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class FormDirectorChoose : Form
    {
        public FormDirectorChoose()
        {
            InitializeComponent();
        }

        private void FormDirectorChoose_Load(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormDirector fd = new FormDirector();
            this.Hide();
            fd.ShowDialog();
            this.Show();
        }

        private void buttonStat_Click(object sender, EventArgs e)
        {

        }
    }
}
