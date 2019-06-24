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
    public partial class AddProgram : Form
    {
        SqlConnection mydbCon;
        SqlCommand command;
        SqlDataReader reader;

        private void AddProgram_Load(object sender, EventArgs e)
        {

        }


        public AddProgram()
        {
            InitializeComponent();
            FillCombo();
        }


        void FillCombo()
        {
            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
            mydbCon.Open();
            Course cl = new Course();

            command = new SqlCommand("SELECT * FROM Cours", mydbCon);
        
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cl.CodeCours = reader["CodeCours"].ToString();
                cl.NomCourse = reader["NameCourse"].ToString();
                cl.HeuresCours1 =int.Parse( reader["HoursCourse"].ToString());
                 
                MessageBox.Show(cl.CodeCours + " " + cl.NomCourse +" " +cl.HeuresCours1);
                comboBoxCours1.Items.Add(reader["NameCourse"].ToString());
            }

            //DataSet dataSet = new DataSet();
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //adapter.Fill(dataSet);
            mydbCon.Close();
        


         //   MessageBox.Show(dataSet.Tables[2].Rows.ToString);

         

        }
    }
}
