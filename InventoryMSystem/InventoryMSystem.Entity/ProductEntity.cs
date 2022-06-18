using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMSystem.Entity
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string  CategoryName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public double ProductUnitPrice { get; set; }
        public string SupplierName { get; set; }
    }
}
