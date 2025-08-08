﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Inventory
{
    internal interface IInventoryItem
    {
       public int Id { get; }
       public string Name { get; }
     public int Quantity { get; set; }
    }
}
