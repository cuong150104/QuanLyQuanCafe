using QuanLyQuanCafe.DTO_model_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO_controller_
{
    public class FoodDAO
    {
        private static FoodDAO instance;// instance là để tạo ra category là duy nhất

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food> ();

            string query = "select * from dbo.food where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            foreach(DataRow  item in data.Rows )
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
    }
}
