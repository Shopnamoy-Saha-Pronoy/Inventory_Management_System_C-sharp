using InventoryMSystem.Data;
using InventoryMSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMSystem.Repository
{
    public class CategoryDataRepository
    {
        private DataAccess Da { get; set; }

        public CategoryDataRepository()
        {
            this.Da = new DataAccess();
        }

        public List<CategoryEntity> GetAll(string key)
        {
            List<CategoryEntity> categoryList = new List<CategoryEntity>();
            string sql;
            try
            {
                if (key == null)
                    sql = "select * from CategoryData;";
                else
                    sql = "select * from CategoryData where CategoryName like '%" + key + "';";
                var dt = this.Da.ExecuteQueryTable(sql);

                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    CategoryEntity c = ConvertToEntity(dt.Rows[ax]);
                    categoryList.Add(c);
                }

                return categoryList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private CategoryEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;

            var category = new CategoryEntity();

            //category.Id = Convert.ToInt32(row["Id"].ToString());
            category.CategoryName = row["CategoryName"].ToString();
           
            return category;
        }

        public bool Save(CategoryEntity ud)
        {
            try
            {
                var sql = "insert into CategoryData values('" + ud.CategoryName + "');";
                var rowCount = this.Da.ExecuteDML(sql);
                if (rowCount == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //public bool Edit(CategoryEntity ud)
        //{
        //    try
        //    {
        //        var sql = "update CategoryData set CategoryName = '" + ud.CategoryName + "' where Id = " + ud.Id + ";";
        //        var rowCount = this.Da.ExecuteDML(sql);
        //        if (rowCount == 1)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        public bool Delete(string name)
        {
            try
            {
                var sql = "delete from CategoryData where CategoryName='" + name + "';";
                var rowCount = this.Da.ExecuteDML(sql);
                if (rowCount == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
