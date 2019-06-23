using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal_CS_BourassaMarie
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection mydbConnection;
        SqlCommand command;
        SqlDataReader reader;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            mydbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            labelLogin.Visible = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            mydbConnection.Open();
            command = new SqlCommand("SELECT * FROM LoginInfo WHERE Username =@cd", mydbConnection);
            command.Parameters.AddWithValue("cd", textBoxUsername.Text);

            int i = Convert.ToInt32(command.ExecuteScalar());

            reader = command.ExecuteReader(); //execute la commande il la pren a la bd

            while (reader.Read())
            {
                if (i > 0)
                {
                    MessageBox.Show(reader["Idpers"].ToString());
                }
                else

                    MessageBox.Show("Non Trouve");
            }


            mydbConnection.Close();
        }
    }
}
