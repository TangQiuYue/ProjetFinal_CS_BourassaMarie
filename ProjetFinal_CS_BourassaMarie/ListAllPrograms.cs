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
    public partial class ListAllPrograms : Form
    {
        public ListAllPrograms()
        {
            InitializeComponent();
        }
        SqlConnection mydbCon;
        SqlCommand command;
        SqlDataReader reader;

        private void dataGridViewPrograms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {

            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
            mydbCon.Open();

            command = new SqlCommand("SELECT * FROM Programs", mydbCon);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["CodeProgram"], reader["NameProgram"], reader["Course1"], reader["Course2"], reader["Course3"], reader["Course4"], reader["Course5"]);
            }
            mydbCon.Close();


        }
    }
}
