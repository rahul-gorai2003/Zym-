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

namespace GymManagementSystem
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            String lname = textBox2.Text;

            String gender = "";
            bool isChecked = radioButton1.Checked;
            if(isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePicker1.Text;
            String mob = textBox3.Text;
            String email = textBox4.Text;
            String jdate = dateTimePicker2.Text;
            String state = textBox5.Text;
            String city = textBox6.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-BO01214\\SQLEXPRESS; database= gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewStaff (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Stat_e,City) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "'," + mob + ",'" + email + "','" + jdate + "','" + state + "','" + city + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }
    }
}
