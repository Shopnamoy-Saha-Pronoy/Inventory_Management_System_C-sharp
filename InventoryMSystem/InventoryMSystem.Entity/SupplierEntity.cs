using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMSystem.Entity
{
    public class SupplierEntity
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public double SupplierBill { get; set; }
        public double SupplierPaidAmount { get; set; }
    }
}
