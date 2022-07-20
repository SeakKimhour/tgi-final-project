using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postgresqlTest.DataModels
{
    internal class CustomerInfoModel
    {

        public CustomerInfoModel(string cs_id, string cs_national_id, string cs_phone_number, string cs_room_number, DateTime cs_checkin_date, DateTime cs_checkout_date, int cs_number_day, int cs_number_adult, int cs_number_children, string cs_discount_type, double cs_advance_payment, string cs_names)
        {

            this.cs_id = cs_id;
            this.cs_national_id = cs_national_id;
            this.cs_phone_number = cs_phone_number;
            this.cs_room_number = cs_room_number;
            this.cs_checkin_date = cs_checkin_date;
            this.cs_checkout_date = cs_checkout_date;
            this.cs_number_day = cs_number_day;
            this.cs_number_adult = cs_number_adult;
            this.cs_number_children = cs_number_children;
            this.cs_discount_type = cs_discount_type;
            this.cs_advance_payment = cs_advance_payment;

            this.cs_name = cs_names;
        }


        public string cs_id { get; set; }
        public string cs_national_id { get; set; }
        public string cs_phone_number { get; set; }
        public string cs_room_number { get; set; }

        public DateTime cs_checkin_date { get; set; }

        public DateTime cs_checkout_date { get; set; }

        public int cs_number_day { get; set; }

        public int cs_number_adult { get; set; }
        public int cs_number_children { get; set; }
        public string cs_discount_type { get; set; }
        public double cs_advance_payment { get; set; }
        public string cs_name { get; set; }
    }
}

