using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO_controller_
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        public static int TableWidth = 50;
        public static int TableHeight = 50;

        private AccountDAO() { }


        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            
           DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {userName, passWord});

            return result.Rows.Count>0;
        }
    }
}
