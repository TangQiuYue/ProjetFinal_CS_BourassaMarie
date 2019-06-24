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
    public partial class SystemDeGestion : Form
    {
        public SystemDeGestion()
        {
            InitializeComponent();
        }

        private void MenuItemQuit_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Do you really want to quit this program?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Goodbye!", "Goodbye", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void menuItemAddProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProgram addNew = new AddProgram();
            addNew.Show();
        }
    }
}
