using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database10.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        private String getuname()
        {
            // Get data from the database
            con.Open();
            String syntax = "select Value from system where Property='username'";
            cmd=new SqlCommand(syntax, con);
            dr= cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return (temp);

        }

        private String getpass()
        {
            // Get data from the database
            con.Open();
            String syntax = "select Value from system where Property='password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read(); 
            String temp = dr[0].ToString();
            con.Close();
            return (temp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String Uname = getuname(), Upass = getpass(), name, pass;
            name=textBox1.Text;
            pass = textBox2.Text;
            if (name.Equals(Uname) && pass.Equals(Upass))
            {
                //login
                label4.Hide();
                AppBody obj= new AppBody();
                this.Hide();
                obj.Show();
            }
            else
            {
                //dont login
                label4.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
