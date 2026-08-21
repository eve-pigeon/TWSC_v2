using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public Sprite icon;
    public ItemType type;
    public ActionType actionType;
    public string itemName;
    [TextArea(15, 20)]
    public string description;

    [Header("Combinable Object Variables")]
    public Item requiredItem;
    public Item postCombinationItem;
}

public enum ItemType
{
    Inspectable,
    Usable,
    Collectable
}

public enum ActionType
{
    MultiUse,
    SingleUse,
    Combine
}