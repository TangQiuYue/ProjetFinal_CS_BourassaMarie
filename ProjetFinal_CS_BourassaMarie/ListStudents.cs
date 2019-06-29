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
    public partial class ListStudents : Form
    {
        public ListStudents()
        {
            InitializeComponent();
        }
        SqlConnection mydbCon;
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        int pos = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
            mydbCon.Open();

            command = new SqlCommand("SELECT * FROM Programs", mydbCon);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                
            }
            mydbCon.Close();
        }

        private void ListStudents_Load(object sender, EventArgs e)
        {
            mydbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\TQY_06\Documents\ProjetFinal_CS_BourassaMarie\ProjetFinal_CS_BourassaMarie\FinalProjDB.mdf;
            Integrated Security=True");
            mydbCon.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Students", mydbCon);
            adapter.Fill(table);
            showData(pos);
        }
        private void showData(int index)
        {
            try
            {
                textBoxPermCode.Text = table.Rows[index][1].ToString();
                textBoxName.Text = table.Rows[index][2].ToString();
                textBoxFirstName.Text = table.Rows[index][3].ToString();
                textBoxTelephone.Text = table.Rows[index][4].ToString();
                textBoxAddress.Text = table.Rows[index][5].ToString();
                textBoxProgram.Text = table.Rows[index][6].ToString();
                textBoxDoB.Text = table.Rows[index][7].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            if (pos == 0)
            {
                MessageBox.Show("You're already at the first student");
            }
            else
            {
                pos = 0;
                showData(pos);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                showData(pos);
            
            }
            else
            {
                MessageBox.Show("Can't go any further, this is the first student!");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < table.Rows.Count)
            {
                pos++;
                showData(pos);
               
            }
            else
            {
                MessageBox.Show("Can't go any further, this is the last student!");
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (pos < table.Rows.Count)
            {
                pos++;
                showData(pos);
            }
            else
            {
                MessageBox.Show("This is already the last student!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
