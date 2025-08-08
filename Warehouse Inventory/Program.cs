using System;
using Warehouse_Inventory;

class Program
{
    static void Main()
    {
        var manager = new WareHouseManager();

        manager.SeedData();

        Console.WriteLine("Grocery Items:");
        manager.PrintAllItems(manager.GroceriesRepo);

        Console.WriteLine("\nElectronic Items:");
        manager.PrintAllItems(manager.ElectronicsRepo);

  
        Console.WriteLine("\n--- Testing Exceptions ---");

        try
        {
            manager.ElectronicsRepo.AddItem(new ElectronicItem(1, "Tablet", 5, "Apple", 12)); 
        }
        catch (DuplicateItemException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            manager.GroceriesRepo.RemoveItem(999); 
        }
        catch (ItemNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            manager.ElectronicsRepo.UpdateQuantity(1, -5); 
        }
        catch (InvalidQuantityException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

