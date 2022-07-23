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
    public partial class FormAvailableRoom : Form
    {
        FormMainMenu frm = null;
        public FormAvailableRoom()
        {
            InitializeComponent();
        }

        private void FormAvailableRoom_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateItems()
        {
            frm = (FormMainMenu)Application.OpenForms["FormMainMenu"];
            List<RoomModel> a_room = frm.Gs.RoomList();
            RoomCard[] roomCards = new RoomCard[a_room.Count()];


            for (int i = 0; i < a_room.Count(); i++)
            {
                roomCards[i] = new RoomCard();
                roomCards[i].RoomType = a_room[i].r_type;
                roomCards[i].RoomNumber = a_room[i].r_number;
                roomCards[i].RoomStatus = a_room[i].r_status;
                roomCards[i].switchColor(a_room[i].r_status);
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                    flowLayoutPanel1.Controls.Add(roomCards[i]);

            }
        }

        private void roomCard1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
