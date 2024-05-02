using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_Management_System
{
    public partial class AppBody : Form
    {
        public AppBody()
        {
            InitializeComponent();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            LogIn_Timer.Start();

        }

        private void LogIn_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.25;
            }
            else
            {
                LogIn_Timer.Stop();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            Form1 obj= new Form1();
            this.Hide();
            obj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isExpanded;
        const int MaxWidth=300;
        const int MinWidth=90;

        private void Toggle_Button_Click(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                retractGUI();
            }
            Sliding_Timer.Start();
        }

        private void Sliding_Timer_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                // retract panel
                Sliding_Panel.Width -= 30;
                if (Sliding_Panel.Width <= MinWidth)
                {
                    // stop retracting
                    isExpanded = false;
                    Sliding_Timer.Stop();
                    this.Refresh();
                }
            }
            else
            {
                // expand panel
                Sliding_Panel.Width += 30;
                if (Sliding_Panel.Width >= MaxWidth)
                {
                    // stop expanding
                    isExpanded = true;
                    Sliding_Timer.Stop();
                    expandGUI();
                    this.Refresh(); 
                }
            }
        }
        public void expandGUI()
        {
            Books.Text = "BOOKS";
            Borrowers.Text = "BORROWERS";
            Transactions.Text = "TRANSACTIONS";
            Settings.Text = "SETTINGS";
            About.Text = "About";

            Books.Image = null;
            Borrowers.Image = null;
            Transactions.Image = null;
            Settings.Image = null;
            About.Image = null;
        }
        public void retractGUI()
        {
            Books.Text = "B";
            Borrowers.Text = "BR";
            Transactions.Text = "T";
            Settings.Text = "S";
            About.Text = "A";

            Books.Image = null;
            Borrowers.Image = null;
            Transactions.Image = null;
            Settings.Image = null;
            About.Image = null;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Sliding_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Books_Click(object sender, EventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(10, 10);
        }
    }
}
