namespace Library_Management_System
{
    partial class AppBody
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.LogIn_Timer = new System.Windows.Forms.Timer(this.components);
            this.Sliding_Timer = new System.Windows.Forms.Timer(this.components);
            this.Sliding_Panel = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.Toggle_Button = new System.Windows.Forms.Button();
            this.Books = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Borrowers = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.MinimiseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Sliding_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogIn_Timer
            // 
            this.LogIn_Timer.Interval = 50;
            this.LogIn_Timer.Tick += new System.EventHandler(this.LogIn_Timer_Tick);
            // 
            // Sliding_Timer
            // 
            this.Sliding_Timer.Tick += new System.EventHandler(this.Sliding_Timer_Tick);
            // 
            // Sliding_Panel
            // 
            this.Sliding_Panel.BackgroundImage = global::Library_Management_System.Properties.Resources.space_3;
            this.Sliding_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sliding_Panel.Controls.Add(this.About);
            this.Sliding_Panel.Controls.Add(this.Toggle_Button);
            this.Sliding_Panel.Controls.Add(this.Books);
            this.Sliding_Panel.Controls.Add(this.Settings);
            this.Sliding_Panel.Controls.Add(this.Borrowers);
            this.Sliding_Panel.Controls.Add(this.Transactions);
            this.Sliding_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sliding_Panel.Location = new System.Drawing.Point(0, 43);
            this.Sliding_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sliding_Panel.Name = "Sliding_Panel";
            this.Sliding_Panel.Size = new System.Drawing.Size(300, 819);
            this.Sliding_Panel.TabIndex = 1;
            this.Sliding_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Sliding_Panel_Paint);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Location = new System.Drawing.Point(0, 415);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(300, 87);
            this.About.TabIndex = 7;
            this.About.Text = "ABOUT";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.UseVisualStyleBackColor = false;
            // 
            // Toggle_Button
            // 
            this.Toggle_Button.BackColor = System.Drawing.Color.Transparent;
            this.Toggle_Button.FlatAppearance.BorderSize = 0;
            this.Toggle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Toggle_Button.Location = new System.Drawing.Point(0, 0);
            this.Toggle_Button.Name = "Toggle_Button";
            this.Toggle_Button.Size = new System.Drawing.Size(300, 87);
            this.Toggle_Button.TabIndex = 2;
            this.Toggle_Button.UseVisualStyleBackColor = false;
            this.Toggle_Button.Click += new System.EventHandler(this.Toggle_Button_Click);
            // 
            // Books
            // 
            this.Books.BackColor = System.Drawing.Color.Transparent;
            this.Books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Books.FlatAppearance.BorderSize = 0;
            this.Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Books.ForeColor = System.Drawing.Color.White;
            this.Books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Books.Location = new System.Drawing.Point(0, 83);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(300, 87);
            this.Books.TabIndex = 6;
            this.Books.Text = "BOOKS";
            this.Books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Books.UseVisualStyleBackColor = false;
            this.Books.Click += new System.EventHandler(this.Books_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Location = new System.Drawing.Point(0, 331);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(300, 87);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "SETTINGS";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.UseVisualStyleBackColor = false;
            // 
            // Borrowers
            // 
            this.Borrowers.BackColor = System.Drawing.Color.Transparent;
            this.Borrowers.FlatAppearance.BorderSize = 0;
            this.Borrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowers.ForeColor = System.Drawing.Color.White;
            this.Borrowers.Location = new System.Drawing.Point(0, 165);
            this.Borrowers.Name = "Borrowers";
            this.Borrowers.Size = new System.Drawing.Size(300, 87);
            this.Borrowers.TabIndex = 5;
            this.Borrowers.Text = "BORROWERS";
            this.Borrowers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Borrowers.UseVisualStyleBackColor = false;
            this.Borrowers.Click += new System.EventHandler(this.button3_Click);
            // 
            // Transactions
            // 
            this.Transactions.BackColor = System.Drawing.Color.Transparent;
            this.Transactions.FlatAppearance.BorderSize = 0;
            this.Transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transactions.ForeColor = System.Drawing.Color.White;
            this.Transactions.Location = new System.Drawing.Point(0, 248);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(300, 87);
            this.Transactions.TabIndex = 4;
            this.Transactions.Text = "TRANSACTIONS";
            this.Transactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transactions.UseVisualStyleBackColor = false;
            this.Transactions.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Library_Management_System.Properties.Resources.space_3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.LogOffButton);
            this.panel1.Controls.Add(this.MinimiseButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1761, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LogOffButton
            // 
            this.LogOffButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOffButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOffButton.BackgroundImage")));
            this.LogOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOffButton.FlatAppearance.BorderSize = 0;
            this.LogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOffButton.ForeColor = System.Drawing.Color.Black;
            this.LogOffButton.Location = new System.Drawing.Point(1604, 5);
            this.LogOffButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(36, 35);
            this.LogOffButton.TabIndex = 2;
            this.LogOffButton.UseVisualStyleBackColor = false;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimiseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimiseButton.BackgroundImage")));
            this.MinimiseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimiseButton.FlatAppearance.BorderSize = 0;
            this.MinimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimiseButton.ForeColor = System.Drawing.Color.Black;
            this.MinimiseButton.Location = new System.Drawing.Point(1648, 5);
            this.MinimiseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.Size = new System.Drawing.Size(36, 35);
            this.MinimiseButton.TabIndex = 3;
            this.MinimiseButton.UseVisualStyleBackColor = false;
            this.MinimiseButton.Click += new System.EventHandler(this.MinimiseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(1694, 5);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(36, 35);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1761, 862);
            this.Controls.Add(this.Sliding_Panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.Sliding_Panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer LogIn_Timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Button MinimiseButton;
        private System.Windows.Forms.Panel Sliding_Panel;
        private System.Windows.Forms.Button Toggle_Button;
        private System.Windows.Forms.Timer Sliding_Timer;
        private System.Windows.Forms.Button Books;
        private System.Windows.Forms.Button Borrowers;
        private System.Windows.Forms.Button Transactions;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button About;
    }
}