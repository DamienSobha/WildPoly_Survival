
using System.Globalization;
using UnityEngine;

public interface IPickable
{
    void PickUp(Inventory inventory);

    GameObject ItemObject();

    int ItemQuantity();

    string GetItemName();

    string GetItemDescription();
}
