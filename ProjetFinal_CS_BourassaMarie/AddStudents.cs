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
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
            fillCombo();
        }
        SqlConnection mydbCon;
        SqlCommand command;
        SqlDataReader reader;

        private void buttonGenerateCode_Click(object sender, EventArgs e)
        {
            try
            {
                string lastFour = textBoxLastName.Text.Substring(0, 3);
                string firstFirst = textBoxFirstName.Text.Substring(0, 1);
                string dOb = dateTimePickerDoB.Text;
                textBoxPermanentCode.Text = lastFour + firstFirst + dOb;
                textBoxPermanentCode.Visible = true;
                buttonAddStudent.Enabled = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Last name and First name must be entered to generate a permanent code!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxTelNum.Text = "";
            textBoxAdress.Text = "" ;
            textBoxPermanentCode.Text = "" ;
            textBoxPermanentCode.Visible = false;
            comboBoxProgs.Text  = "";
            labelProgramCode.Text = "";
            labelProgramCode.Visible = false;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            try
            {

                mydbCon.Open();
                command = new SqlCommand("Insert into Students (CodeStudent, NameStudent, FirstNameStudent, TelStudent, AddressStudent, ProgramStudent, DateOfBirth)" +
                    "values(@cp, @ln, @fn, @tel, @add, @cprog, @dOb)", mydbCon);
                command.Parameters.AddWithValue("cp", textBoxPermanentCode.Text);
                command.Parameters.AddWithValue("ln", textBoxLastName.Text);
                command.Parameters.AddWithValue("fn", textBoxFirstName.Text);
                command.Parameters.AddWithValue("tel", textBoxTelNum.Text);
                command.Parameters.AddWithValue("add", textBoxAdress.Text);
                command.Parameters.AddWithValue("cprog", labelProgramCode.Text);
                command.Parameters.AddWithValue("dOb", dateTimePickerDoB.Text);
                command.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show("Student successfully added");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("This permanent code already exists. \nPlease add a letter or number at the end to make it unique.");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mydbCon.Close();
                }
            }
           
        }

        private void fillCombo()
        {
            comboBoxProgs.Items.Clear();
            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");

            mydbCon.Open();

            command = new SqlCommand("SELECT * FROM Programs", mydbCon);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxProgs.Items.Add(reader["NameProgram"].ToString());
               
            }
            mydbCon.Close();


        }

        private void comboBoxProgs_SelectedIndexChanged(object sender, EventArgs e)
        {
            mydbCon.Open();

            command = new SqlCommand("SELECT CodeProgram FROM Programs where NameProgram=@cd", mydbCon);
            command.Parameters.AddWithValue("cd", comboBoxProgs.Text);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                labelProgramCode.Text = reader["CodeProgram"].ToString();
                labelProgramCode.Visible = true;
            }
            mydbCon.Close();
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
        }
    }
}
