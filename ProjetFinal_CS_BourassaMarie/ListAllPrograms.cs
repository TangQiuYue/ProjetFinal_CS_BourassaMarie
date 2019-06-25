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
            reload();
        }
        SqlConnection mydbCon;
        SqlCommand command;
        SqlDataReader reader;
        private void reload()
        {

            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
            mydbCon.Open();

            command = new SqlCommand("SELECT * FROM Programs", mydbCon);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string code = reader["CodeProgram"].ToString();
                string name = reader["NameProgram"].ToString();
                string course1 = reader["Course1"].ToString();
                string course2 = reader["Course2"].ToString();
                string course3 = reader["Course3"].ToString();
                string course4 = reader["Course4"].ToString();
                string course5 = reader["Course5"].ToString();
                dataGridViewPrograms.Rows.Add(code, name, course1, course2, course3, course4, course5 );
            }
            mydbCon.Close();
            mydbCon.Close();
            
        }
        private void ListAllPrograms_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'finalProjDBDataSet.Programs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.programsTableAdapter.Fill(this.finalProjDBDataSet.Programs);

        }

        private void dataGridViewPrograms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
