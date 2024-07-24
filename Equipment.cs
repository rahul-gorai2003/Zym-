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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String EquiName = textBox1.Text;
            String Description = richTextBox1.Text;
            String MUsed = textBox2.Text;
            String DDate = dateTimePicker1.Text;
            Int64 cost = Int64.Parse(textBox3.Text);





            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-BO01214\\SQLEXPRESS; database= gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Equipments (EquipName,EDescription,MUsed,DDate,Cost) values ('" + EquiName + "','" + Description + "','" + MUsed + "','" + DDate + "'," + cost + ")";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.","Inserted", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.ResetText();
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}
