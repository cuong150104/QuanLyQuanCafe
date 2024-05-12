using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_model_
{
    public class BillInfo
    {
        private int iD;
        private int billID;
        private int foodID;
        private int count;
        public BillInfo(int iD, int billID, int foodID)
        {
            this.ID = iD;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }

        public BillInfo(DataRow row) {

            this.ID = (int)row["id"];
            this.BillID = (int)row["idbill"];
            this.FoodID = (int)row["idfood"];
            this.Count = (int)row["count"];

        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
