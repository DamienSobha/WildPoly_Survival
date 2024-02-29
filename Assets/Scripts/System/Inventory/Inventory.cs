using NUnit.Framework.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]   
public class Inventory
{
    private List<ItemClass> AllItemList = new List<ItemClass>();
    private List<InventoryStack> InventoryStacks = new List<InventoryStack>();
    private int InventoryStackSize;

    public Inventory(int InventorySize)
    {
        InventoryStackSize = InventorySize;
    }

    public void AddItemToInventory(ItemClass item)
    {
        AllItemList.Add(item);
        SortItems();
    }

    public void AddStackToInventory(InventoryStack stack)
    {
        InventoryStacks.Add(stack);
    }

    public void AddStackToInventory(InventoryStack stack, Inventory inventory)
    {
        if(inventory.InventoryStacks.Count >= InventoryStackSize){
            DropStack(stack);
        }
        else
        {
            inventory.AddStackToInventory(stack);
        }
    }

    public void SortItems()
    {
        InventoryStack WeaponStack = new InventoryStack();
        InventoryStack ConsumableStack = new InventoryStack();
        InventoryStack CraftingStack = new InventoryStack();

        if(AllItemList != null && AllItemList.Count > 0)
        {
            foreach (ItemClass itemObj in AllItemList)
            {
                if (itemObj.GetWeapon())
                {
                    WeaponStack.AddItemToStack(itemObj);
                }
                else if (itemObj.GetConsumable())
                {
                    ConsumableStack.AddItemToStack(itemObj);
                }
                else if (itemObj.GetCrafting())
                {
                    CraftingStack.AddItemToStack(itemObj);
                }
                else
                {
                    Debug.Log("Item Type not Identified");
                }
            }
            Debug.Log("SortComplete");

            // Add the stack to the List 
            //if(WeaponStack.)
        }

    }

    public void DropStack(InventoryStack stack)
    {

    }
}
