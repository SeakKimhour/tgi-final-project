using postgresqlTest.DataModels;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace WindowsFormHotelManagementSystem.Forms
{
    public partial class FormCheckIn : Form
    {
        FormMainMenu frm = (FormMainMenu)Application.OpenForms["FormMainMenu"];
        RoomModel roomChoosen = null;
        double total = 0;
        public FormCheckIn()
        {

            InitializeComponent();
            txtnumofdays.Enabled = false;
            txtsubtotal.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void addType()
        {
            frm.Gs.getRoomType();
            comboRoomType.Items.Clear();
            listRoomType = frm.Gs.RoomType;
            foreach (String type in listRoomType)
            {
                comboRoomType.Items.Add(type);
            }
        }
        List<String> listRoomType = new List<String>();
        private void FormCheckIn_Load(object sender, EventArgs e)
        {
            addType();

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

            CustomerInfoModel insertCustomer = new CustomerInfoModel();
            RoomModel roomchoice = new RoomModel();
            List<RoomModel> listroom = frm.Gs.getAvailableiRoomList();

            errprovider.Clear();
            int temp = 0;

            if (string.IsNullOrEmpty(txtguestname.Text))
            {
                errprovider.SetIconAlignment(txtguestname, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtguestname, "Name cannot be blanked.");
                txtguestname.Focus();
                txtguestname.SelectAll();
                return;
            }
            string guest_name = txtguestname.Text;



            if (int.TryParse(txtguestname.Text, out temp) == true)
            {
                errprovider.SetIconAlignment(txtguestname, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtguestname, "Name must not contained integer");
                txtguestname.Focus();
                txtguestname.SelectAll();
                return;
            }
            guest_name = txtguestname.Text;
            insertCustomer.cs_name = guest_name;


            if (string.IsNullOrEmpty(txtnationalid.Text))
            {
                errprovider.SetIconAlignment(txtnationalid, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtnationalid, "National ID cannot be blanked.");
                txtnationalid.Focus();
                txtnationalid.SelectAll();
                return;
            }
            string national_id = txtnationalid.Text;
            insertCustomer.cs_national_id = national_id;


            if (string.IsNullOrEmpty(comboRoomType.Text))
            {
                errprovider.SetIconAlignment(comboRoomType, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(comboRoomType, "Room type cannot be blanked.");
                comboRoomType.Focus();
                comboRoomType.SelectAll();
                return;
            }
            string room_type = comboRoomType.Text;


            if (txtphone.Text.Length > 10)
            {
                errprovider.SetIconAlignment(txtphone, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtphone, "Please input the phone number correctly!");
                txtphone.Focus();
                txtphone.SelectAll();
                return;
            }
            String phone_number = txtphone.Text;
            insertCustomer.cs_phone_number = phone_number.ToString();


            if (comboRoomNum.Text == "")
            {
                errprovider.SetIconAlignment(comboRoomNum, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(comboRoomNum, "Please input the room number correctly!");

                return;
            }
            String room_number = comboRoomNum.Text;
            insertCustomer.cs_room_number = room_number;


            if (dtpcheckoutdate.Value.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy"))
            {
                errprovider.SetIconAlignment(dtpcheckoutdate, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(dtpcheckoutdate, "Checkout date must not the same date as checkin");
                return;
            }
            insertCustomer.cs_checkout_date = dtpcheckoutdate.Value;
            insertCustomer.cs_checkin_date = dtpcheckindate.Value;
            int numOfdays = int.Parse(txtnumofdays.Text);
            insertCustomer.cs_number_day = numOfdays;



            if (int.TryParse(txtnumofadults.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtnumofadults, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtnumofadults, "Please input the number of adutls correctly!");
                txtnumofadults.Focus();
                txtnumofadults.SelectAll();
                return;
            }
            int numOfadults = int.Parse(txtnumofadults.Text);
            insertCustomer.cs_number_adult = numOfadults;


            if (int.TryParse(txtnumofchildren.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtnumofchildren, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtnumofchildren, "Please input the number of children correctly!");
                txtnumofchildren.Focus();
                txtnumofchildren.SelectAll();
                return;
            }
            int numOfchildren = int.Parse(txtnumofadults.Text);
            insertCustomer.cs_number_children = numOfchildren;


            if (int.TryParse(txtdiscount.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtdiscount, ErrorIconAlignment.MiddleLeft);
                errprovider.SetError(txtdiscount, "Please input the number of children correctly!");
                txtdiscount.Focus();
                txtdiscount.SelectAll();
                return;

            }
            String discount = txtdiscount.Text;
            insertCustomer.cs_discount = discount;


            if (discount.Length < 1)
            {
                errprovider.SetIconAlignment(txtdiscount, ErrorIconAlignment.MiddleLeft);
                errprovider.SetError(txtdiscount, "Discount cannot be larger than 100");
                txtdiscount.Focus();
                txtdiscount.SelectAll();
                return;
            }

            discount = discount;




            insertCustomer.cs_discount = discount.ToString() + "%";
            if (int.TryParse(txtadvance.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtadvance, ErrorIconAlignment.MiddleLeft);
                errprovider.SetError(txtadvance, "Please input the advance payment correctly!");
                txtadvance.Focus();
                txtadvance.SelectAll();
                return;

            }
            int advance_payment = int.Parse(txtadvance.Text);
            insertCustomer.cs_advance_payment = advance_payment;
            insertCustomer.cs_id = Guid.NewGuid().ToString();
            txtguestname.Clear();
            txtnationalid.Clear();
            txtdiscount.Clear();
            txtnumofchildren.Clear();

            txtphone.Clear();

            txtadvance.Clear();
            dtpcheckindate.Value = DateTime.Now;
            dtpcheckoutdate.Value = DateTime.Now;
            comboRoomType.SelectedValue = "";
            comboRoomNum.SelectedValue = "";
            txtnumofadults.Clear();
            listRoomType = frm.Gs.RoomType;

            comboRoomNum.Items.Clear();
            frm.Gs.checkin(insertCustomer);
            additem();
            addType();
            txtnumofdays.Clear();
            txtsubtotal.Clear();



        }


        public void additem()
        {
            frm.Gs.getRoomType();
            comboRoomNum.Items.Clear();
            roomAvailable = frm.Gs.findRoomByType(comboRoomType.Text);
            if (roomAvailable.Count > 0)
            {
                txtsubtotal.Text = roomAvailable[0].r_cost.ToString("C");
                roomChoosen = roomAvailable[0];
                foreach (RoomModel room in roomAvailable)
                {
                    comboRoomNum.Items.Add(room.r_number);
                }
            }
        }
        List<RoomModel> roomAvailable = new List<RoomModel>();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frm.backHome();
        }

        private void lblDiscountType_Click(object sender, EventArgs e)
        {

        }


        private void comboRoomType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            additem();

        }

        private void dtpcheckoutdate_ValueChanged(object sender, EventArgs e)
        {
            double numDay = (((dtpcheckoutdate.Value).Subtract(dtpcheckindate.Value)).Days + 1);
            txtnumofdays.Text = numDay.ToString();
            total = roomChoosen.r_cost * numDay;
            txtsubtotal.Text = (total).ToString("C");

        }

        private void txtdiscounttype_Leave(object sender, EventArgs e)
        {
            if (txtdiscount.Text.Length > 0)
            {
                txtsubtotal.Text = (total - (total * (double.Parse(txtdiscount.Text) / 100))).ToString("C");
            }


        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtguestname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnumofadults_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnumofchildren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtadvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
