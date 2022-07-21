using Npgsql;
using postgresqlTest.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postgresqlTest.Services
{
    internal class DataServices
    {
        //create 3 list then pass to this function that data will be stored in the list
        public void selectAllData(List<UserLoginModel> userLoginList, List<CustomerInfoModel> customerInfoList, List<RoomModel> roomList)
        {
            //make db connection
            string dbInfo = "Server=ec2-23-20-224-166.compute-1.amazonaws.com;Port=5432;User Id=qoyarodwurvhwk;Password=6f3163d0e09fce46ac86fbf29260d0b119a2025ff85cb94871cacf87c7dfa11d;Database=d1hrugp6772lpc";
            NpgsqlConnection objConn = new NpgsqlConnection(dbInfo);
            objConn.Open();

            //read from userlogin table
            NpgsqlCommand cmd1 = new NpgsqlCommand("SELECT * FROM public.userlogin;", objConn);
            NpgsqlDataReader rdr = cmd1.ExecuteReader();

            while (rdr.Read())
            {
                userLoginList.Add(new UserLoginModel(rdr.GetGuid(0).ToString(), rdr.GetString(1), rdr.GetString(2)));
            }
            rdr.DisposeAsync();


            //read from customerinfo table
            cmd1.CommandText = "SELECT * FROM public.customerinfo;";
            NpgsqlDataReader rdr2 = cmd1.ExecuteReader();
            while (rdr2.Read())
            {
                customerInfoList.Add(new CustomerInfoModel(rdr2.GetGuid(0).ToString(), rdr2.GetString(1), rdr2.GetString(2), rdr2.GetString(3), rdr2.GetDateTime(4), rdr2.GetDateTime(5), rdr2.GetInt32(6), rdr2.GetInt32(7), rdr2.GetInt32(8), rdr2.GetString(9), Convert.ToDouble(rdr2.GetValue(10)), rdr2.GetString(11)));
                //Console.WriteLine($"{rdr2.GetGuid(0).ToString()} {rdr2.GetString(1)}, {rdr2.GetString(2)}, {rdr2.GetString(3)} {rdr2.GetDate(4)}, {rdr2.GetDate(5)} {rdr2.GetInt32(6)}, {rdr2.GetInt32(7)}, {rdr2.GetInt32(8)}  {rdr2.GetString(9)}, {rdr2.GetValue(10)}");

            }
            rdr.DisposeAsync();


            //read from room table
            cmd1.CommandText = "SELECT * FROM public.room;";
            NpgsqlDataReader rdr3 = cmd1.ExecuteReader();
            while (rdr3.Read())
            {
                roomList.Add(new RoomModel(rdr3.GetGuid(0).ToString(), rdr3.GetString(1), rdr3.GetString(2), rdr3.GetString(3), rdr3.GetString(4), rdr3.GetInt32(5)));
            }
            rdr.DisposeAsync();

            //close db
            objConn.Close();
        }

        public void updateRoom(string r_id, string r_status, string r_cs_id)
        {
            string dbInfo = "Server=ec2-23-20-224-166.compute-1.amazonaws.com;Port=5432;User Id=qoyarodwurvhwk;Password=6f3163d0e09fce46ac86fbf29260d0b119a2025ff85cb94871cacf87c7dfa11d;Database=d1hrugp6772lpc";
            NpgsqlConnection objConn = new NpgsqlConnection(dbInfo);
            objConn.Open();

            var cmd = new NpgsqlCommand();
            cmd.Connection = objConn;
            cmd.CommandText = $"UPDATE public.room SET r_status ='{r_status}' ,r_cs_id='{r_cs_id}' WHERE r_id='{r_id}'; ";
            cmd.ExecuteNonQuery();

            objConn.Close();
        }

        public void insertCustomer(string cs_id, string cs_national_id, string cs_phone_number, string cs_room_number, DateTime cs_checkin_date, DateTime cs_checkout_date, int cs_number_day, int cs_number_adult, int cs_number_children, string cs_discount_type, double cs_advance_payment, string cs_name)
        {
            string dbInfo = "Server=ec2-23-20-224-166.compute-1.amazonaws.com;Port=5432;User Id=qoyarodwurvhwk;Password=6f3163d0e09fce46ac86fbf29260d0b119a2025ff85cb94871cacf87c7dfa11d;Database=d1hrugp6772lpc";
            NpgsqlConnection objConn = new NpgsqlConnection(dbInfo);
            objConn.Open();

            var cmd = new NpgsqlCommand();
            cmd.Connection = objConn;
            cmd.CommandText = $"INSERT INTO public.customerinfo(cs_id, cs_national_id, cs_phone_number, cs_room_number, cs_checkin_date, cs_checkout_date, cs_number_day, cs_number_adult, cs_number_children, cs_discount, cs_advance_payment, cs_name) VALUES('{cs_id}','{cs_national_id}', '{cs_phone_number}', '{cs_room_number}', '{cs_checkin_date}', '{cs_checkout_date}', '{cs_number_day}', '{cs_number_adult}', '{cs_number_children}', '{cs_discount_type}', '{cs_advance_payment}','{cs_name}'); ";
            cmd.ExecuteNonQuery();

            objConn.Close();
        }




        public void deleteCustomer(string delete_customer_by, string delete_customer_by_data)
        {
            string dbInfo = "Server=ec2-23-20-224-166.compute-1.amazonaws.com;Port=5432;User Id=qoyarodwurvhwk;Password=6f3163d0e09fce46ac86fbf29260d0b119a2025ff85cb94871cacf87c7dfa11d;Database=d1hrugp6772lpc";
            NpgsqlConnection objConn = new NpgsqlConnection(dbInfo);
            objConn.Open();

            var cmd = new NpgsqlCommand();
            cmd.Connection = objConn;
            cmd.CommandText = $"DELETE FROM public.customerinfo WHERE {delete_customer_by} = '{delete_customer_by_data}' ";
            cmd.ExecuteNonQuery();

            objConn.Close();
        }

        public void updateCustomer(CustomerInfoModel cs)
        {
            string dbInfo = "Server=ec2-23-20-224-166.compute-1.amazonaws.com;Port=5432;User Id=qoyarodwurvhwk;Password=6f3163d0e09fce46ac86fbf29260d0b119a2025ff85cb94871cacf87c7dfa11d;Database=d1hrugp6772lpc";
            NpgsqlConnection objConn = new NpgsqlConnection(dbInfo);
            objConn.Open();

            var cmd = new NpgsqlCommand();
            cmd.Connection = objConn;
            cmd.CommandText = $"UPDATE public.customerinfo SET cs_national_id='{cs.cs_national_id}', cs_phone_number='{cs.cs_phone_number}', cs_room_number='{cs.cs_room_number}', cs_checkin_date='{cs.cs_checkin_date}', cs_checkout_date='{cs.cs_checkout_date}', cs_number_day='{cs.cs_number_day}', cs_number_adult='{cs.cs_number_adult}', cs_number_children='{cs.cs_number_children}', cs_discount='{cs.cs_discount}', cs_advance_payment='{cs.cs_advance_payment}' WHERE  cs_id= '{cs.cs_id}';";
            cmd.ExecuteNonQuery();

            objConn.Close();
        }
    }
}
