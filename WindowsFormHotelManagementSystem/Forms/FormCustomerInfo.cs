using postgresqlTest.DataModels;
using postgresqlTest.Services;
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
    public partial class FormCustomerInfo : Form
    {
        public FormCustomerInfo()
        {
            InitializeComponent();
        }

        private void FormCustomerInfo_Load(object sender, EventArgs e)
        {
            FormMainMenu frm = (FormMainMenu)Application.OpenForms["FormMainMenu"];
            List<CustomerInfoModel> customerInfoList = new List<CustomerInfoModel>();
            customerInfoList = frm.Gs.CustomerInfoList();

            foreach (CustomerInfoModel customerInfo in customerInfoList)
            {
                customerDataGrid.Rows.Add(customerInfo.cs_name, customerInfo.cs_national_id, customerInfo.cs_phone_number, customerInfo.cs_room_number, customerInfo.cs_checkin_date, customerInfo.cs_checkout_date);
            }
        }

        private void customerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
