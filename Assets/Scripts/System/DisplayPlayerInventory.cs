using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerInventory : MonoBehaviour
{
    [SerializeField] private GameObject ItemUIPrefab;
    [SerializeField] private Transform ItemContainer;

    private string ItemName;
    private int ItemQuantity;
    private Sprite ItemSprite;

   

    void Update()
    {
        //if(Player_inventory.GetInventory.Count > 0)
        //{
        //    Debug.Log(Player_inventory.GetInventory.Count);
        //    foreach (InventorySlots InvSlot in Player_inventory.GetInventory)
        //    {
        //        GameObject ItemButton = Instantiate(ItemUIPrefab, ItemContainer);
        //        Item_UIFunction UIBtn = ItemButton.GetComponent<Item_UIFunction>();
        //        GameObject Item = InvSlot.slots[0];

        //        //Check what itemType the Item is and Set the Values to it
        //        if (Item.GetComponent<Heal_Item>() != null)
        //        {
        //            ItemSprite = Item.GetComponent<Heal_Item>().GetHeal_Property.ItemSprite;
        //            ItemQuantity = InvSlot.slots.Count;
        //            ItemName = Item.GetComponent<Heal_Item>().GetHeal_Property.ItemName;
        //        }
        //        else if (Item.GetComponent<Food_Item>() != null)
        //        {
        //            ItemSprite = Item.GetComponent<Food_Item>().GetFood_Property.FoodSprite;
        //            ItemQuantity = InvSlot.slots.Count;
        //            ItemName = Item.GetComponent<Food_Item>().GetFood_Property.FoodName;
        //        }


        //        UIBtn.image.sprite = ItemSprite;
        //        UIBtn.QuantityID.text = ItemQuantity.ToString();
        //        UIBtn.ItemName.text = ItemName;
        //        UIBtn.ItemProperty = Item;
        //    }
        //}
    }
}
