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

namespace WindowsFormHotelManagementSystem.Forms
{
    public partial class FormCheckOut : Form
    {
        CustomerInfoModel csFound = null;
        FormMainMenu frm = null;
        public FormCheckOut()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (txtAddtionPrice.Text.Length > 0)
            {
                csFound.cs_advance_payment = (csFound.cs_advance_payment + Double.Parse(txtAddtionPrice.Text));
            }
            txtGuestName.Clear();
            dtp_check_in_date.Value = DateTime.Now;
            dtp_check_out_date.Value = DateTime.Now;
            txtTotalNight.Clear();
            txtAddtionPrice.Clear();

            frm.backHome();
            frm.Gs.checkOut(csFound);

        }

        private void cbb_room_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            dtp_check_in_date.Enabled = false;
            frm = (FormMainMenu)Application.OpenForms["FormMainMenu"];
            List<RoomModel> roomList = frm.Gs.getBookedRoom();

            foreach (RoomModel r in roomList)
            {
                cbb_room.Items.Add(r.r_number.ToString());
            }

        }

        private void cbb_room_SelectedIndexChanged(object sender, EventArgs e)

        {
            txtGuestName.Clear();
            dtp_check_in_date.Value = DateTime.Now;
            dtp_check_out_date.Value = DateTime.Now;
            txtTotalNight.Clear();
            txtAddtionPrice.Clear();
            csFound = frm.Gs.searchByCSid(cbb_room.Text);
            if (csFound != null)
            {
                txtGuestName.Text = csFound.cs_name;
                dtp_check_in_date.Value = csFound.cs_checkin_date;
                dtp_check_out_date.Value = csFound.cs_checkout_date;
                txtTotalNight.Text = csFound.cs_number_day.ToString();
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frm.backHome();
        }
    }
}
