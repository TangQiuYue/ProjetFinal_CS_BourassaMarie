using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal_CS_BourassaMarie
{
    public partial class DeleteProgram : Form
    {
        public DeleteProgram()
        {
            InitializeComponent();
            FillCombo();
        }
        SqlConnection mydbCon;
        SqlCommand command;
        SqlDataReader reader;

        private void DeleteProgram_Load(object sender, EventArgs e)
        {

        }

        void FillCombo()
        {
            comboBoxDeleteSelection.Items.Clear();
            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
            mydbCon.Open();

            command = new SqlCommand("SELECT * FROM Programs", mydbCon);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxDeleteSelection.Items.Add(reader["CodeProgram"].ToString());
               
            }
            mydbCon.Close();

        }

        private void comboBoxDeleteSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
          DialogResult result =  MessageBox.Show("Do you really want to delete " + comboBoxDeleteSelection.Text + " ?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
                mydbCon.Open();

                command = new SqlCommand("DELETE FROM Programs WHERE CodeProgram = @cp", mydbCon);
                command.Parameters.AddWithValue("cp", comboBoxDeleteSelection.Text);
                command.ExecuteNonQuery();
                mydbCon.Close();
            }
            MessageBox.Show("Deleted " + comboBoxDeleteSelection.Text + " Successfully");
            FillCombo();
        }
    }
}
