using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormHotelManagementSystem.Forms
{
    public partial class FormCheckIn : Form
    {
        public FormCheckIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
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


            if (string.IsNullOrEmpty(txtnationalid.Text))
            {
                errprovider.SetIconAlignment(txtnationalid, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtnationalid, "National ID cannot be blanked.");
                txtnationalid.Focus();
                txtnationalid.SelectAll();
                return;
            }
            string national_id = txtnationalid.Text;


            if (string.IsNullOrEmpty(txtroomtype.Text))
            {
                errprovider.SetIconAlignment(txtroomtype, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtroomtype, "Room type cannot be blanked.");
                txtroomtype.Focus();
                txtroomtype.SelectAll();
                return;
            }
            string room_type = txtroomtype.Text;


            if (int.TryParse(txtphone.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtphone, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtphone, "Please input the phone number correctly!");
                txtphone.Focus();
                txtphone.SelectAll();
                return;
            }
            int phone_number = int.Parse(txtphone.Text);


            if (int.TryParse(txtroomnum.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtroomnum, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtroomnum, "Please input the room number correctly!");
                txtroomnum.Focus();
                txtroomnum.SelectAll();
                return;
            }
            int room_number = int.Parse(txtroomnum.Text);


            if (int.TryParse(txtnumofdays.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtnumofdays, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtnumofdays, "Please input the number of days correctly!");
                txtnumofdays.Focus();
                txtnumofdays.SelectAll();
                return;
            }
            int numOfdays = int.Parse(txtnumofdays.Text);


            if (int.TryParse(txtnumofadults.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtnumofadults, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtnumofadults, "Please input the number of adutls correctly!");
                txtnumofadults.Focus();
                txtnumofadults.SelectAll();
                return;
            }
            int numOfadults = int.Parse(txtnumofadults.Text);


            if (int.TryParse(txtnumofchildren.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtnumofchildren, ErrorIconAlignment.MiddleRight);
                errprovider.SetError(txtnumofchildren, "Please input the number of children correctly!");
                txtnumofchildren.Focus();
                txtnumofchildren.SelectAll();
                return;
            }
            int numOfchildren = int.Parse(txtnumofadults.Text);


            if (int.TryParse(txtdiscounttype.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtdiscounttype, ErrorIconAlignment.MiddleLeft);
                errprovider.SetError(txtdiscounttype, "Please input the number of children correctly!");
                txtdiscounttype.Focus();
                txtdiscounttype.SelectAll();
                return;

            }
            int discount_type = int.Parse(txtdiscounttype.Text);

            if (discount_type > 100)
            {
                errprovider.SetIconAlignment(txtdiscounttype, ErrorIconAlignment.MiddleLeft);
                errprovider.SetError(txtdiscounttype, "Discount cannot be larger than 100");
                txtdiscounttype.Focus();
                txtdiscounttype.SelectAll();
                return;
            }

            discount_type = discount_type;


            if (int.TryParse(txtsubtotal.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtsubtotal, ErrorIconAlignment.MiddleLeft);
                errprovider.SetError(txtsubtotal, "Please input the sub total correctly!");
                txtsubtotal.Focus();
                txtsubtotal.SelectAll();
                return;

            }
            int subTotal = int.Parse(txtsubtotal.Text);


            if (int.TryParse(txtadvance.Text, out temp) == false)
            {
                errprovider.SetIconAlignment(txtadvance, ErrorIconAlignment.MiddleLeft);
                errprovider.SetError(txtadvance, "Please input the advance payment correctly!");
                txtadvance.Focus();
                txtadvance.SelectAll();
                return;

            }
            int advance_payment = int.Parse(txtadvance.Text);
        }
    }
}
