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

        int count = 0;

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

            command = new SqlCommand("SELECT * FROM LoginInfo WHERE Username =@cd AND Password =@pw", mydbConnection);
            command.Parameters.AddWithValue("cd", textBoxUsername.Text);
            command.Parameters.AddWithValue("pw", textBoxPassword.Text);
            command.Connection = mydbConnection;
            mydbConnection.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            mydbConnection.Close();

            bool successLogin = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            if (successLogin)
            {
                MessageBox.Show("Welcome!", "Validaton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SystemDeGestion frm2 = new SystemDeGestion();
                this.Hide();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("I don't recognise this information.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                count++;
            }
            if (count == 3)
            {
                MessageBox.Show("Please contact the administration. \n\n\nGoodBye!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
