using postgresqlTest.DataModels;
using postgresqlTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormHotelManagementSystem.Service
{
    internal class generalService
    {
        DataServices ds = new DataServices();
        private List<UserLoginModel> userLoginList = new List<UserLoginModel>();
        private List<CustomerInfoModel> customerInfoList = new List<CustomerInfoModel>();
        private List<RoomModel> roomList = new List<RoomModel>();


        public List<UserLoginModel> UserLoginList() { return userLoginList; }
        public List<CustomerInfoModel> CustomerInfoList() { return customerInfoList; }
        public List<RoomModel> RoomList() { return roomList; }
        public List<RoomModel> getAvalibleRoom()
        {
            List<RoomModel> res = new List<RoomModel>();

            foreach (RoomModel r in roomList)
            {
                if (r.r_status.ToLower() == "Booked".ToLower())
                {
                    res.Add(r);
                }
            }
            return res;
        }
        public RoomModel findRoomByNum(String r_Num)
        {
            RoomModel csid = null;
            foreach (RoomModel r in roomList)
            {
                if (r.r_number.Equals(r_Num))
                {
                    csid = r;
                    break;
                }
            }
            return csid;
        }

        public CustomerInfoModel searchByCSid(String rRum)

        {
            RoomModel csid = findRoomByNum(rRum);


            foreach (CustomerInfoModel cs in customerInfoList)
            {
                if (cs.cs_id.Equals(csid.r_cs_id))
                {
                    return cs;
                }
            }
            return null;
        }

        public void getAllDataFromDB()
        {
            ds.selectAllData(userLoginList, customerInfoList, roomList);
        }
        public void checkIn(CustomerInfoModel csInfo)
        {
            if (csInfo == null)
            {
                return;
            }
            customerInfoList.Add(csInfo);
            ds.insertCustomer(csInfo.cs_national_id, csInfo.cs_phone_number, csInfo.cs_room_number, csInfo.cs_checkin_date, csInfo.cs_checkout_date, csInfo.cs_number_day, csInfo.cs_number_adult, csInfo.cs_number_children, csInfo.cs_discount_type, csInfo.cs_advance_payment);
        }
        public bool verifyLogin(UserLoginModel user)
        {
            foreach (UserLoginModel dbuser in userLoginList)
            {
                if (dbuser.user_name.Equals(user.user_name) && dbuser.user_password.Equals(user.user_password))
                {

                    return true;

                }
            }
            return false;
        }
        public void checkOut(CustomerInfoModel cs)
        {
            for (int i = 0; i < roomList.Count; i++)
            {
                if (roomList[i].r_number.Equals(cs.cs_room_number))
                {
                    RoomModel temp = roomList[i];
                    temp.r_status = "Avaliable";
                    roomList[i] = temp;
                    ds.updateRoom(roomList[i].r_id, "Avaliable");
                    break;
                }
            }

        }
    }
}
