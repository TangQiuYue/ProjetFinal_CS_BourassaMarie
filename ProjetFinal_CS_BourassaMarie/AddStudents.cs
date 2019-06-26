using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal_CS_BourassaMarie
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerateCode_Click(object sender, EventArgs e)
        {
            string lastFour = textBoxLastName.Text.Substring(0, 3);
            string firstFirst = textBoxFirstName.Text.Substring(0, 1);
            string dOb = dateTimePickerDoB.Text;
            textBoxPermanentCode.Text = lastFour + firstFirst + dOb;
            textBoxPermanentCode.Visible = true;
            buttonAddStudent.Enabled = true;
        }
    }
}
