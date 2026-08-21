using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    public Image image;

    [HideInInspector] public Item item;

    public void InitialiseItem(Item newItem)
    {
        item = newItem;
        if (image != null)
        {
            image.sprite = newItem.icon;
        }
    }

    public void CallOpenExaminePanel()
    {
        if (InventoryManager.instance.itemInCombineMode)
        {
            TryCombine(InventoryUI.instance.currentItem.item, item);
        }
        InventoryUI.instance.currentItem = this;
        InventoryUI.instance.OpenExaminePanel(item);
    }

    public void TryCombine(Item firstItem, Item secondItem)
    {
        if (firstItem.requiredItem == secondItem)
        {
            Debug.Log("Items combined!");
            InventoryManager.instance.RemoveItem(firstItem);
            InventoryManager.instance.RemoveItem(secondItem);
            InventoryManager.instance.AddItem(item.postCombinationItem);
        }
        else
        {
            Debug.Log("These items cannot be combined");
        }

        InventoryManager.instance.itemInCombineMode = false;
        InventoryManager.instance.currentItem = null;
    }
}
