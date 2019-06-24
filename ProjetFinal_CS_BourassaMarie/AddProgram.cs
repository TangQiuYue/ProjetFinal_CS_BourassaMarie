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

        void renderNull()
        {
            labelCombo1.Text = "";
            labelCombo2.Text = "";
            labelCombo3.Text = "";
            labelCombo4.Text = "";
            labelCombo5.Text = "";
        }

        public AddProgram()
        {
            InitializeComponent();
            FillCombo();
            renderNull();
        }

        void fillLabel(ComboBox combobox, Label label)
        {
            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
            mydbCon.Open();

            command = new SqlCommand("SELECT CodeCours FROM Cours where NameCourse=@cd", mydbCon);
            command.Parameters.AddWithValue("cd", combobox.Text);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                label.Text = reader["CodeCours"].ToString();
            }
            label.Visible = true;
        }
        void FillCombo()
        {
            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
            mydbCon.Open();

            command = new SqlCommand("SELECT * FROM Cours", mydbCon);
        
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxCours1.Items.Add(reader["NameCourse"].ToString());
                comboBoxCours2.Items.Add(reader["NameCourse"].ToString());
                comboBoxCours3.Items.Add(reader["NameCourse"].ToString());
                comboBoxCours4.Items.Add(reader["NameCourse"].ToString());
                comboBoxCours5.Items.Add(reader["NameCourse"].ToString());
            }
            mydbCon.Close();

        }
        void clearAfterAdd()
        {
             textBoxCourseCode.Text = "";
             textBoxCourseName.Text = "";
             textBoxHours.Text = "" ;

            buttonAdd.Enabled = true;
            buttonBack.Enabled = true;
            labelCodeCours.Visible = false;
            labelNomCours.Visible = false;
            labelHeuresCours.Visible = false;
            textBoxCourseCode.Visible = false;
            textBoxCourseName.Visible = false;
            textBoxHours.Visible = false;
            comboBoxCours1.Visible = true;
            comboBoxCours2.Visible = true;
            comboBoxCours3.Visible = true;
            comboBoxCours4.Visible = true;
            comboBoxCours5.Visible = true;
            buttonAddCourse.Visible = false;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxProgramCode.Text = "";
            textBoxProgramName.Text = "";
            comboBoxCours1.Text = "";
            comboBoxCours2.Text = "";
            comboBoxCours3.Text = "";
            comboBoxCours4.Text = "";
            comboBoxCours5.Text = "";
            textBoxCourseCode.Text = null;
            textBoxCourseName.Text = null;
            textBoxHours.Text = null;

            buttonAdd.Enabled = true;
            buttonBack.Enabled = true;
            labelCodeCours.Visible = false;
            labelNomCours.Visible = false;
            labelHeuresCours.Visible = false;
            textBoxCourseCode.Visible = false;
            textBoxCourseName.Visible = false;
            textBoxHours.Visible = false;
            comboBoxCours1.Visible = true;
            comboBoxCours2.Visible = true;
            comboBoxCours3.Visible = true;
            comboBoxCours4.Visible = true;
            comboBoxCours5.Visible = true;
            buttonAddCourse.Visible = false;
            renderNull();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (labelCombo1.Text == "")
            {
                MessageBox.Show("You must select a class in Course 1 options");
            }
            else
            {
                try
                {
                    mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
                    mydbCon.Open();

                    command = new SqlCommand("Insert into Programs (CodeProgram, NameProgram, Course1)" +
                        "values(@cp, @np, @c1)", mydbCon);
                    command.Parameters.AddWithValue("cp", textBoxProgramCode.Text);
                    command.Parameters.AddWithValue("np", textBoxProgramName.Text);
                    command.Parameters.AddWithValue("c1", labelCombo1.Text);

                    command.ExecuteNonQuery();

                    command.Dispose();

                    if (labelCombo2.Text != null)
                    {
                        command = new SqlCommand("UPDATE Programs SET Course2 = @c2 WHERE CodeProgram = @cp ", mydbCon);
                        command.Parameters.AddWithValue("c2", labelCombo2.Text);
                        command.Parameters.AddWithValue("cp", textBoxProgramCode.Text);
                    }
                    command.ExecuteNonQuery();
                    command.Dispose();

                    if (labelCombo3.Text != "")
                    {
                        command = new SqlCommand("UPDATE Programs SET Course3 = @c3 WHERE CodeProgram = @cp ", mydbCon);
                        command.Parameters.AddWithValue("c3", labelCombo3.Text);
                        command.Parameters.AddWithValue("cp", textBoxProgramCode.Text);
                    }
                    command.ExecuteNonQuery();
                    command.Dispose();

                    if (labelCombo4.Text != "")
                    {
                        command = new SqlCommand("UPDATE Programs SET Course4 = @c4 WHERE CodeProgram = @cp ", mydbCon);
                        command.Parameters.AddWithValue("c4", labelCombo4.Text);
                        command.Parameters.AddWithValue("cp", textBoxProgramCode.Text);
                    }

                    if (labelCombo5.Text != "")
                    {
                        command = new SqlCommand("UPDATE Programs SET Course5 = @c5 WHERE CodeProgram = @cp ", mydbCon);
                        command.Parameters.AddWithValue("c5", labelCombo5.Text);
                        command.Parameters.AddWithValue("cp", textBoxProgramCode.Text);
                    }
                    command.ExecuteNonQuery();
                    command.Dispose();

                    mydbCon.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning!",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Program Successfully Inserted");
        }

        private void comboBoxCours1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLabel(comboBoxCours1, labelCombo1);
        }

        private void comboBoxCours2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLabel(comboBoxCours2, labelCombo2);
        }

        private void comboBoxCours3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLabel(comboBoxCours3, labelCombo3);
        }

        private void comboBoxCours4_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLabel(comboBoxCours4, labelCombo4);
        }

        private void comboBoxCours5_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLabel(comboBoxCours5, labelCombo5);
        }

        private void buttonAddNewCourse_Click(object sender, EventArgs e)
        {
            comboBoxCours1.Visible = false;
            comboBoxCours2.Visible = false;
            comboBoxCours3.Visible = false;
            comboBoxCours4.Visible = false;
            comboBoxCours5.Visible = false;
            buttonAdd.Enabled = false;
            buttonBack.Enabled = false;
            labelCodeCours.Visible = true;
            labelNomCours.Visible = true;
            labelHeuresCours.Visible = true;
            textBoxCourseCode.Visible = true;
            textBoxCourseName.Visible = true;
            textBoxHours.Visible = true;
            buttonAddCourse.Visible = true;

        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
                mydbCon.Open();

                command = new SqlCommand("Insert into Cours (CodeCours, NameCourse, HoursCourse)" +
                    "values(@cp, @np, @c1)", mydbCon);
                command.Parameters.AddWithValue("cp", textBoxCourseCode .Text);
                command.Parameters.AddWithValue("np", textBoxCourseName.Text);
                command.Parameters.AddWithValue("c1", textBoxHours.Text);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Course Successfully Inserted");
            clearAfterAdd();
            FillCombo();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemDeGestion addNew = new SystemDeGestion();
            addNew.Show();

        }
    }
}
