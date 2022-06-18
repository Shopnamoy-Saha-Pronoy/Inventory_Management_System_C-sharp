using InventoryMSystem.Data;
using InventoryMSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMSystem.Repository
{
    public class CartDataRepository
    {
        private DataAccess Da { get; set; }

        public CartDataRepository()
        {
            this.Da = new DataAccess();
        }

        public List<ProductEntity> GetAll(string category,string name)
        {
            List<ProductEntity> productList = new List<ProductEntity>();
            string sql;
            try
            {

                if(name==null)
                {
                    sql = "select * from ProductData where CategoryName = '" + category + "' and ProductName like '" + name + "%';";
                }
                else
                {
                    sql = "select * from ProductData where CategoryName = '" + category + "' and ProductName like '%" + name + "'   ;";
                }
                
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
                var sql = "select distinct CategoryName from CategoryData; ";
                var dt = this.Da.ExecuteQuery(sql);

                for (int ax = 0; ax < dt.Tables[0].Rows.Count; ax++)
                {
                    c.Add(dt.Tables[0].Rows[ax]["CategoryName"].ToString());
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
                var sql = "select SupplierName from ProductData; ";
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

        public void UpdateQuantirty(string name,int quantity)
        {
            var sql = "update ProductData set ProductQuantity=" + quantity + " where ProductName='" + name + "';";

            try
            {
                this.Da.ExecuteDML(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Add(CartEntity cartList)
        {
            try
            {
                var sql = "insert into SalesData values('" + cartList.ProductName + "'," + cartList.Quantity + "," + cartList.Price + "," + cartList.TotalBill + ");";

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
