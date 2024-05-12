using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_model_
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckOut;
        
        private DateTime? dateCheckIn;

        private int status;
        private int discount;

        public int ID { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public DateTime? DateCheckIn { get; set; }

        public int Status { get; set; }
        public int Discount { get => discount; set => discount = value; }

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount)
        {
            this.ID = id;   
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }
        public Bill(DataRow row) {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];

            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.Status = (int)row["status"]; ;
            this.Discount = (int)row["discount"];
        }


    }
}
