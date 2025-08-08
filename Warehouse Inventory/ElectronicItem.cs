using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Inventory
{
    internal class ElectronicItem:IInventoryItem
    {
       
            public int Id { get; }
            public string Name { get; }
            public int Quantity { get; set; }
            public string Brand { get; }
            public int WarrantyMonths { get; }

            public ElectronicItem(int id, string name, int quantity, string brand, int warrantyMonths)
            {
                this.Id = id;
                this.Name = name;
               this.Quantity = quantity;
                this.Brand = brand;
               this.WarrantyMonths = warrantyMonths;
            }
        }
    }
