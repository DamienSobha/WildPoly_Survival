using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class InventoryStack
{
    private List<ItemClass> Itemstack = new List<ItemClass>();


    public void AddItemToStack(ItemClass item)
    {
        
    }

















    [SerializeField] private ItemClass ItemStackData;
    [SerializeField] private int StackSize;

    public ItemClass GetStackItemData { get { return ItemStackData; } }
    public int SlotStackSize { get { return StackSize; } }

    public InventoryStack(ItemClass itemData, int SizeAmount)
    {
        ItemStackData = itemData;
        StackSize = SizeAmount;
    }

    public InventoryStack()
    {
        ClearSlot();
    }

    public bool CheckStackSize(int ItemAmount, out int Remainder)
    {
        Remainder = ItemStackData.MaxItemCount - StackSize;
        return CheckStackSize(ItemAmount);
    }

    public bool CheckStackSize(int ItemAmount)
    {
        if (StackSize + ItemAmount <= ItemStackData.MaxItemCount)
        { return true; }
        else { return false; }
    }

    public void ClearSlot()
    {
        ItemStackData = null;
        StackSize = -1;

    }

    public void AddToStack(int ItemAmount)
    {
        StackSize += ItemAmount;
    }

    public void RemoveToStack(int ItemAmount)
    {
        StackSize -= ItemAmount;
    }
}
