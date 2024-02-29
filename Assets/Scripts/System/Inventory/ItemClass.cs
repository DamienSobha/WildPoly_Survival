using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemClass: ScriptableObject
{
    public string ItemName;
    public Sprite ItemIcon;
    [TextArea(4, 3)]
    public string ItemDescription;
    public int ItemIndex;
    public int ItemQuantity;
    public int MaxItemCount;
    public bool IsStackable;
    public Sprite ItemSprite;
    public GameObject ItemObject;

    public abstract ItemClass GetItem();
    public abstract Weapon_Item GetWeapon();
    public abstract Consumable_item GetConsumable();
    public abstract Crafting_item GetCrafting();
}
