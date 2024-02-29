using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Weapon Item", menuName = "Scripts/Scriptable/Items/Weapon")]
public class Weapon_Item : ItemClass
{
    [Header("Weapon")]
    public WeaponType weaponType;
    public enum WeaponType
    {
        Sword,
        Bow,
        Pickaxe,
        Axe
    }


    public override Consumable_item GetConsumable()
    {
        return null;
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
        return this;
    }
}
