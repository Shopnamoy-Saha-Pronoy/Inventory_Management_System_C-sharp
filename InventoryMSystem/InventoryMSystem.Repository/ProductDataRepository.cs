using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using InventoryMSystem.Data;
using InventoryMSystem.Entity;

namespace InventoryMSystem.Repository
{
    public class ProductDataRepository
    {
        private DataAccess Da { get; set; }

        public ProductDataRepository()
        {
            this.Da = new DataAccess();
        }

        public List<ProductEntity> GetAll(string key)
        {
            List<ProductEntity> productList = new List<ProductEntity>();
            string sql;
            try
            {
                if (key == null)
                    sql = "select * from ProductData;";
                else
                    sql = "select * from ProductData where ProductName like '%" + key + "';";
                var dt = this.Da.ExecuteQueryTable(sql);               

                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    ProductEntity u = ConvertToEntity(dt.Rows[ax]);
                    productList.Add(u);
                }

                return productList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private ProductEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;
                        
            var product = new ProductEntity();
            product.Id = Convert.ToInt32(row["Id"].ToString());
            product.ProductName = row["ProductName"].ToString();
            product.CategoryName = row["CategoryName"].ToString();
            product.ProductQuantity = Convert.ToInt32(row["ProductQuantity"].ToString());
            product.ProductPrice = Convert.ToDouble(row["ProductPrice"].ToString());
            product.ProductUnitPrice = Convert.ToDouble(row["ProductUnitPrice"].ToString());
            product.SupplierName = row["SupplierName"].ToString();
            return product;
        }


        public List<string> GetCategory()
        {
            List<string> c = new List<string>();
            try
            {
                var sql = "select CategoryName from CategoryData; ";
                var dt = this.Da.ExecuteQueryTable(sql);

                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    c.Add(dt.Rows[ax]["CategoryName"].ToString());
                }

                return c;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<string> GetSupplier()
        {
            List<string> c = new List<string>();
            try
            {
                var sql = "select distinct SupplierName from SupplierData; ";
                var dt = this.Da.ExecuteQuery(sql);

                for (int ax = 0; ax < dt.Tables[0].Rows.Count; ax++)
                {
                    c.Add(dt.Tables[0].Rows[ax]["SupplierName"].ToString());
                }
                return c;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Add(ProductEntity ud)
        {
            try
            {
                var sql = @"insert into ProductData values('" + ud.ProductName + "','"
                                                             + ud.CategoryName + "',"
                                                             + ud.ProductQuantity + ","
                                                             + ud.ProductPrice + ","
                                                             + ud.ProductUnitPrice + ",'"
                                                             + ud.SupplierName + "');";
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

        public bool Edit(ProductEntity ud)
        {
            try
            {
                var sql = "update ProductData set CategoryName='" + ud.CategoryName + "',ProductQuantity="
                                                                    + ud.ProductQuantity + ",ProductPrice="
                                                                    + ud.ProductPrice + ",ProductUnitPrice="
                                                                    + ud.ProductUnitPrice + ",SupplierName='"
                                                                    + ud.SupplierName + "' where ProductName = '"
                                                                    + ud.ProductName + "';";
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

        public bool Delete(string name)
        {
            try
            {
                var sql = "delete from ProductData where ProductName='" + name + "';";
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
