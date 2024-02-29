using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IPickable
{
    [SerializeField] private ItemData ItemData;


    public string GetItemDescription()
    {
        return ItemData.ItemDescription;
    }

    public string GetItemName()
    {
        return ItemData.ItemName;
    }

    public GameObject ItemObject()
    {
        return gameObject;
    }

    public int ItemQuantity()
    {
        return ItemData.ItemQuantity;
    }

    public void PickUp(Inventory inventory)
    {
        if(inventory != null)
        {
            if(inventory.GetInventoryStackSize > inventory.MaxInventorySize)
            {

            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
