using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new  Crafting Item", menuName = "Scripts/Scriptable/Items/Crafting")]
public class Crafting_item : ItemClass
{
    [Header("Craft")]
    public CraftingType craftType;
    public enum CraftingType
    {
        Recipe,
        Consumable,
        Storable,
        Usable
    }


    public override Consumable_item GetConsumable()
    {
        return null;
    }

    public override Crafting_item GetCrafting()
    {
        return this;
    }

    public override ItemClass GetItem()
    {
        return this;
    }

    public override Weapon_Item GetWeapon()
    {
        return null;   
    }
}
