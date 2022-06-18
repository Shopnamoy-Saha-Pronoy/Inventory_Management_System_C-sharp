using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using InventoryMSystem.Data;
using InventoryMSystem.Entity;
using System.Data;

namespace InventoryMSystem.Repository
{
    public class SupplierDataRepository
    {
        private DataAccess Da { get; set; }

        public SupplierDataRepository()
        {
            this.Da = new DataAccess();
        }

        public List<SupplierEntity> GetAll(string key)
        {
            List<SupplierEntity> supplierList = new List<SupplierEntity>();
            string sql;
            try
            {
                if (key == null)
                    sql = "select * from SupplierData;";
                else
                    sql = "select * from SupplierData where UserName like'%" + key + "%';";
                var dt = this.Da.ExecuteQueryTable(sql);

                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    SupplierEntity s = ConvertToEntity(dt.Rows[ax]);
                    supplierList.Add(s);
                }

                return supplierList;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        private SupplierEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;
           
            var supplier = new SupplierEntity();

            //supplier.Id = Convert.ToInt32(row["Id"].ToString());
            supplier.SupplierName = row["SupplierName"].ToString();
            supplier.SupplierAddress = row["SupplierAddress"].ToString();
            supplier.SupplierBill = Convert.ToDouble(row["SupplierBill"].ToString());
            supplier.SupplierPaidAmount = Convert.ToDouble(row["SupplierPaidAmount"].ToString());
            return supplier;
        }

        public bool Save(SupplierEntity ud)
        {
            try
            {
                var sql = "insert into SupplierData values('" + ud.SupplierName + "','" + ud.SupplierAddress + "'," + ud.SupplierBill + "," + ud.SupplierPaidAmount + ");";
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

        public bool Edit(SupplierEntity ud)
        {
            try
            {
                var sql = "update SupplierData set SupplierAddress = '" + ud.SupplierAddress + "', SupplierBill= "
                                                                        + ud.SupplierBill + " ,SupplierPaidAmount="
                                                                        + ud.SupplierPaidAmount + "  where SupplierName = '"
                                                                        + ud.SupplierName + "',";
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
                var sql = "delete from SupplierData where SupplierName=" + name + ";";
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
