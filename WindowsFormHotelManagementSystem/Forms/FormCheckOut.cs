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

        }

        private void cbb_room_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            frm = (FormMainMenu)Application.OpenForms["FormMainMenu"];
            List<RoomModel> roomList = frm.Gs.getAvalibleRoom();

            foreach (RoomModel r in roomList)
            {
                cbb_room.Items.Add(r.r_number.ToString());
            }

        }

        private void cbb_room_SelectedIndexChanged(object sender, EventArgs e)

        {

            csFound = frm.Gs.searchByCSid(cbb_room.Text);
            txtGuestName.Text = csFound.cs_name;
            dtp_check_out_date.Value = csFound.cs_checkin_date;
            dtp_check_in_date.Value = csFound.cs_checkout_date;
            txtTotalNight.Text = csFound.cs_number_day.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddtionPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGuestName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTotalNight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
