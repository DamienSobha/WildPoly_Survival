using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new ItemData",menuName = "Create New ItemData")]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public string ItemType;
    [TextArea(4, 3)]
    public string ItemDescription;
    public int ItemIndex;
    public int ItemQuantity;
    public int MaxItemCount;
    public bool IsStackable;
    public Sprite ItemSprite;
    public GameObject ItemObject;
}
