using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigoudBoxUserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Quitter l'application?", "Message de confirmation", MessageBoxButtons.OKCancel) == DialogResult.No)
            {

            }
            else
            {
                Close();
            }
        }
    }
}
