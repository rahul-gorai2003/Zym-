using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            String lname = textBox2.Text;

            String gender = "";

            bool isChacked = radioButton1.Checked;

            if(isChacked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePicker1.Text;
            Int64 mob = Int64.Parse(textBox3.Text);
            String email = textBox4.Text;
            String jdate = dateTimePicker2.Text;
            String gtime = comboBox1.Text;
            String address = richTextBox1.Text;
            String memtime = comboBox2.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-BO01214\\SQLEXPRESS; database = gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember(Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Addres,MemberShiptime)values('"+fname+"','"+lname+"','"+gender+"','"+dob+"',"+mob+",'"+email+"','"+jdate+"','"+gtime+"','"+address+"','"+memtime+"')";


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.");
         }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            dateTimePicker1.ResetText();

            textBox3.Clear();
            textBox4.Clear();

            dateTimePicker2.ResetText();
            comboBox1.ResetText();

            richTextBox1.Clear();

            comboBox2.ResetText();
        }
    }
}
