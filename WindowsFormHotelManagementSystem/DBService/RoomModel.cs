using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postgresqlTest.DataModels
{
    internal class RoomModel
    {
        public RoomModel(string r_id, string r_type, string r_number, string r_status, string r_cs_id)
        {
            this.r_id = r_id;
            this.r_type = r_type;
            this.r_number = r_number;
            this.r_status = r_status;
            this.r_cs_id = r_cs_id;
        }

        public string r_id { get; set; }
        public string r_type { get; set; }
        public string r_number { get; set; }
        public string r_status { get; set; }
        public string r_cs_id { get; set; }
    }
}
