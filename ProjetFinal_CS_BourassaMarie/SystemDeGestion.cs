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

        private void addANewProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProgram addNew = new AddProgram();
            addNew.ShowDialog();
        }

        private void deleteAProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProgram del = new DeleteProgram();
            del.ShowDialog();
        }

        private void listAllProgramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAllPrograms listProg = new ListAllPrograms();
            listProg.ShowDialog();
        }

        private void addANewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudents addStudent = new AddStudents();
            addStudent.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to quit this program?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Goodbye!", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void SystemDeGestion_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void deleteAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent delStudent = new DeleteStudent();
            delStudent.ShowDialog();
        }

        private void listStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStudents listStudents = new ListStudents();
            listStudents.ShowDialog();
        }
    }
}
