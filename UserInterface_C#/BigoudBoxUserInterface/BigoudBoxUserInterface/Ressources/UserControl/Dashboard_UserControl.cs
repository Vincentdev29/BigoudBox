using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigoudBoxUserInterface
{
    public partial class Dashboard_UserControl : UserControl
    {

        public Dashboard_UserControl()
        {
            InitializeComponent();
            //DeleteSeance_DomainUpDown.Items.
            Identite_CheckBox.Checked = false;
        }

        private void DeleteSeance_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DeleteSeance_ComboBox.Items.Clear();
            foreach(string i in GestionBDD.GetSeance(DeleteSeance_DateTimePicker.Value.Day.ToString()))
            {
                DeleteSeance_ComboBox.Items.Add(i);
            }
        }

        private void DeleteSeance_Button_Click(object sender, EventArgs e)
        {
            GestionBDD.AddEntre();
        }

        private void ChoiceAdhrent_CheckedListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Identite_CheckBox.Checked)
            {
                IdentiteFiller();
            }
            else
            {
                Identite_DataGridView.Rows.Clear();
            }
        }

        private void IdentiteFiller()
        {
            List<string> line = new List<string>();
            line = InitList_IdentiteDataGridView();
            Identite_DataGridView.Rows.Clear();
            foreach (string i in line)
            {
                Identite_DataGridView.Rows.Add(i,"null");
            }
            Identite_DataGridView.AutoResizeColumns();
        }

        private List<string> InitList_IdentiteDataGridView()
        {
            List<string> array = new List<string>
            {
                "Nom",
                "Prénom",
                "Birthday",
                "Age"
            };

            return array;
        }
    }
}
