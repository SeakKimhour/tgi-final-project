using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using postgresqlTest.DataModels;

namespace WindowsFormHotelManagementSystem.Forms
{
    public partial class RoomCard : UserControl
    {

        public RoomCard()
        {
            InitializeComponent();
            
        }

        public void switchColor(String checkStatus)
        {
            if (checkStatus.Equals("Booked"))
            {
                pnlstatus.BackColor = Color.Red;
            }
            else
                pnlstatus.BackColor = Color.LimeGreen;

        }
        #region Properties
        private string _roomType;
        private string _roomNumber;
        private string _roomStatus;
        private Image _img;

        [Category("Custom Property")]
        public string RoomType
        {
            get { return _roomType; }
            set
            {
                _roomType = value;
                lblroomtype.Text = value;
            }
        }

        [Category("Custom Property")]
        public string RoomNumber
        {
            get { return _roomNumber; }
            set
            {
                _roomNumber = value;
                lblroomnumber.Text = value;
            }
        }

        [Category("Custom Property")]
        public string RoomStatus
        {
            get { return _roomStatus; }
            set
            {
                _roomStatus = value;
                lblroomstatus.Text = value;
            }
        }

        [Category("Custom Property")]
        public Image RoomImage
        {
            get { return _img; }
            set
            {
                _img = value;
                pbximage.Image = value;
            }
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RoomCard_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void RoomCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        FormCheckIn checkin_frm = null;
        FormCheckOut checkout_frm = null;
        private void RoomCard_DoubleClick(object sender, EventArgs e)
        {
            string roomType = lblroomtype.Text;
            string roomNumber = lblroomnumber.Text;
            
            
            if (lblroomstatus.Text.Equals("Avaliable"))
            {
                
                FormMainMenu frm = (FormMainMenu)Application.OpenForms["FormMainMenu"];
                frm.switchForm();
                checkin_frm = (FormCheckIn)Application.OpenForms["FormCheckIn"];


                checkin_frm.getClickedRoom(roomType, roomNumber);

            }

            if (!lblroomstatus.Text.Equals("Avaliable"))
            {

                FormMainMenu frm = (FormMainMenu)Application.OpenForms["FormMainMenu"];
                frm.switchFormCheckOut();
                checkout_frm = (FormCheckOut)Application.OpenForms["FormCheckOut"];


                checkout_frm.getCheckoutInfo(roomNumber);

            }


        }

        private void RoomCard_DoubleClick_1(object sender, EventArgs e)
        {

        }
    }
}
