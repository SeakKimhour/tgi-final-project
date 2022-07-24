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
        private List<String> roomType = new List<String>();

        public List<String> RoomType { get => roomType; }

        public List<UserLoginModel> UserLoginList() { return userLoginList; }
        public List<CustomerInfoModel> CustomerInfoList() { return customerInfoList; }
        public List<RoomModel> RoomList() { return roomList; }
        public List<RoomModel> getBookedRoom()
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
        public List<RoomModel> getAvailableiRoomList()
        {
            List<RoomModel> res = new List<RoomModel>();

            foreach (RoomModel r in roomList)
            {
                if (r.r_status.ToLower() == "Available".ToLower())
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
        public List<RoomModel> findRoomByType(String roomType)
        {
            List<RoomModel> listRoomFound = new List<RoomModel>();
            foreach (RoomModel room in roomList)
            {
                if (room.r_status.Equals("Available"))
                {
                    if (room.r_type.Equals(roomType))
                    {
                        listRoomFound.Add(room);
                    }

                }
            }
            return listRoomFound;
        }
        public void getRoomType()
        {
            roomType.Clear();
            foreach (RoomModel room in roomList)
            {
                if (!roomType.Contains(room.r_type))
                {
                    if (room.r_status.Equals("Available"))
                    {
                        roomType.Add(room.r_type);
                    }

                }
            }
        }
        public void upadteCustomer(String cs_id)
        {
            foreach (CustomerInfoModel cs in customerInfoList)
            {
                if (cs.cs_id.Equals(cs_id))
                {
                    cs.cs_id = cs_id;
                }
            }
        }
        public void checkOut(CustomerInfoModel cs)
        {
            for (int i = 0; i < roomList.Count; i++)
            {
                if (roomList[i].r_number.Equals(cs.cs_room_number))
                {
                    roomList[i].r_status = "Available";
                    ds.updateRoom(roomList[i].r_id, "Available", "");
                    ds.updateCustomer(cs);
                    break;
                }
            }
        }
        public void checkin(CustomerInfoModel cs)
        {
            for (int i = 0; i < roomList.Count; i++)
            {
                if (roomList[i].r_number.Equals(cs.cs_room_number))
                {
                    customerInfoList.Add(cs);
                    roomList[i].r_status = "Booked";
                    getRoomType();
                    roomList[i].r_cs_id = cs.cs_id;

                    ds.insertCustomer(cs.cs_id, cs.cs_national_id, cs.cs_phone_number, cs.cs_room_number, cs.cs_checkin_date, cs.cs_checkout_date, cs.cs_number_day, cs.cs_number_adult, cs.cs_number_children, cs.cs_discount, cs.cs_advance_payment, cs.cs_name);
                    ds.updateRoom(roomList[i].r_id, "Booked", cs.cs_id);

                    break;
                }
            }
        }
    }
}
