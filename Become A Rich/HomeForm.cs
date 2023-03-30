using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Become_A_Rich
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            GameForm Form1 = new GameForm();
            Form1.ShowDialog();
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Желаете ли да затворите приложението ?","Затваряне",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
           
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
           
        }
    }
}
