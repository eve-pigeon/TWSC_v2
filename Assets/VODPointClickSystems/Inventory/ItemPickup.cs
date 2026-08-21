using UnityEngine;
using System;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    public string uniqueID;

    private void Start()
    {
        if (string.IsNullOrEmpty(uniqueID))
        {
            uniqueID = Guid.NewGuid().ToString();
        }

        if (InventoryManager.instance.PickedUpItems.Contains(uniqueID))
        {
            Destroy(gameObject);
        }
    }

    public void PickUpItem()
    {
        InventoryManager.instance.AddItem(item);
        Debug.Log("Item added to inventory");

        InventoryManager.instance.PickedUpItems.Add(uniqueID);
        InventoryUI.instance.ShowPickupDisplay(item);
        Destroy(gameObject);

        HoverDetector.instance.ClearHover();
    }
}
