using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMSystem.Entity
{
    public class CartEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public double TotalBill { get; set; }
        public string OrderDate { get; set; }
    }
}
