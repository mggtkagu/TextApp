using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result==DialogResult.No)
            {

            }
        }
    }
}
