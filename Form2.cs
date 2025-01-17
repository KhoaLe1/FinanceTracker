﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace BudgetTracker
{
    

    public partial class Form2 : Form
    {
        bool mouseDown;
        private Point offset;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        
        

        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel2.Height = BtnDashboard.Height;
            panel2.Top = BtnDashboard.Top;
            panel2.Left = BtnDashboard.Left;


            usrname.Text = Properties.Settings.Default.UserName;

            lbTitle.Text = "DashBoard";

            Dashboard.BringToFront();

            /*
            this.PnlFormLoader.Controls.Clear();
            toDashboard FrmDashboard_Vrb = new toDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
            */


        }

        //Stop the flickering when switching between panels
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {


        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            panel2.Height = BtnDashboard.Height;
            panel2.Top = BtnDashboard.Top;
            panel2.Left = BtnDashboard.Left;


            lbTitle.Text = "DashBoard";
            Dashboard.BringToFront();

        }
        private void BtnMonth_Click(object sender, EventArgs e)
        {
            panel2.Height = BtnMonth.Height;
            panel2.Top = BtnMonth.Top;
            panel2.Left = BtnMonth.Left;

            lbTitle.Text = "Monthly Spending";
            MnthlySpending.BringToFront();

        }
        private void BtnSavings_Click(object sender, EventArgs e)
        {
           panel2.Height = BtnSavings.Height;
            panel2.Top = BtnSavings.Top;
            panel2.Left = BtnSavings.Left;


            lbTitle.Text = "Savings";

        }
        private void BtnBreakdown_Click(object sender, EventArgs e)
        {
            panel2.Height = BtnBreakdown.Height;
            panel2.Top = BtnBreakdown.Top;
            panel2.Left = BtnBreakdown.Left;


            lbTitle.Text = "Visual Breakdown";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {

        }

        private void BtnMonth_Leave(object sender, EventArgs e)
        {

        }

        private void BtnSavings_Leave(object sender, EventArgs e)
        {

        }

        private void BtnBreakdown_Leave(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            panel2.Height = Settings.Height;
            panel2.Top = Settings.Top;
            panel2.Left = Settings.Left;

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BBar1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true; 
        }

        private void MouseMove_event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }
        }

        private void MouseUp_even(object sender, MouseEventArgs e)
        {
            mouseDown = false; 
        }
    }
}
