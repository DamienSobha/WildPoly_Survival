using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Record All the Inventories in the Game
    private List<Inventory> GameInventories = new List<Inventory>();

    // Adds Inventories to the Inventory Manager
    public void AddInventory(Inventory inventory)
    {
        GameInventories.Add(inventory);
    }


    public void SaveInventories(string FileName)
    {
        // Function to save the Current Inventories to File;
    }

    public void LoadInventories(string FileName)
    {
        // Function to load Inventories from File;
    }
}
