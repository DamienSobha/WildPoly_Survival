using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Consumable Item", menuName = "Scripts/Scriptable/Items/Consumable")]
public class Consumable_item : ItemClass
{
    [Header("Consumable")]
    public ConsumeType consumeType;
    public enum ConsumeType
    {
        Storable,
        Usable,
        thoughable
    }


    public override Consumable_item GetConsumable()
    {
        return this;
    }

    public override Crafting_item GetCrafting()
    {
        return null;
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
