using postgresqlTest.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormHotelManagementSystem.Service;

namespace WindowsFormHotelManagementSystem
{
    public partial class FormLogIn : Form
    {
        generalService gs = null;
        public FormLogIn()
        {
            InitializeComponent();

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormLogIn_Resize(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Maximized)
            //    FormBorderStyle = FormBorderStyle.None;
            //else
            //    FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormLogIn_Load(object sender, EventArgs e)
        {
            gs = new generalService();
            gs.getAllDataFromDB();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            UserLoginModel user = new UserLoginModel("", textBoxUsername.Text, textBoxPassword.Text);
            bool verify = gs.verifyLogin(user);
            if (verify)
            {

                FormMainMenu frm = new FormMainMenu();

                this.Close();

                frm.ShowDialog();
            }
            if (!verify)
            {
                MessageBox.Show("Please ensure that your passowrod and userame is correct", "Something wrong");
            }
        }

    }
}
