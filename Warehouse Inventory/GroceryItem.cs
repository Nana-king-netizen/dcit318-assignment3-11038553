using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Inventory
{
    internal class GroceryItem:IInventoryItem
    {
        public int Id { get; }
        public string Name { get; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; }

        public GroceryItem(int id, string name, int quantity, DateTime expiryDate)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.ExpiryDate = expiryDate;
        }
    }
}
