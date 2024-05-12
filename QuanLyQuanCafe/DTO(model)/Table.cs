using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO_model_
{
    public class Table
    {
        private int iD;
        private string name;
        private string status;
        public Table(int id, string name, string status)
        {
            this.iD = id;
            this.name = Name;
            this.status = status;
        }

        public Table(DataRow row)
        {
            this.iD = (int)row["id"];
            this.name = row["name"].ToString();
            this.status = row["status"].ToString();
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
     public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; } 


        }
      
    }
}
