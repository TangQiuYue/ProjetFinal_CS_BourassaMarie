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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }
        SqlConnection mydbCon;
        SqlCommand command;
        SqlDataReader reader;

        private void buttonFind_Click(object sender, EventArgs e)
        {

            checkExists();
            mydbCon.Open();
            command = new SqlCommand("SELECT * FROM Students WHERE CodeStudent =@cp", mydbCon);
            command.Parameters.AddWithValue("cp", textBoxEnterPermCode.Text);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["CodeStudent"], reader["FirstNameStudent"], reader["NameStudent"], reader["DateOfBirth"]);
                labelAreYouSure.Visible = true;
                buttonYes.Visible = true;
                buttonNo.Visible = true;
            }
            mydbCon.Close();
        }


        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            try
            {
                mydbCon.Open();

                command = new SqlCommand("DELETE FROM Students WHERE CodeStudent = @cp", mydbCon);
                command.Parameters.AddWithValue("cp", textBoxEnterPermCode.Text);
                command.ExecuteNonQuery();
                mydbCon.Close();
                MessageBox.Show("Deleted " + textBoxEnterPermCode.Text + " Successfully");
                makeInvisible();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            makeInvisible();
        }
        private void makeInvisible()
        {
            dataGridView1.Rows.Clear();
            textBoxEnterPermCode.Text = "";
            labelAreYouSure.Visible = false;
            buttonYes.Visible = false;
            buttonNo.Visible = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
         void checkExists()
        {
            mydbCon.Open();
            command = new SqlCommand("SELECT * FROM Students WHERE CodeStudent =@cp", mydbCon);
            command.Parameters.AddWithValue("cp", textBoxEnterPermCode.Text);
            int exists = Convert.ToInt32(command.ExecuteScalar());
            if (exists == 0)
            {
                MessageBox.Show("This student does not exist.");
            }
            else
            {
                MessageBox.Show("Student exists!");
            }
            mydbCon.Close();
        }

    }
}
    
