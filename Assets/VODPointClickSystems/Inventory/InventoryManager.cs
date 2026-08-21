using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public Item currentItem;
    public bool itemInUse;
    public bool itemInCombineMode;

    public GameObject[] inventorySlots;
    public GameObject inventoryItemPrefab;

    [HideInInspector] public List<string> PickedUpItems = new List<string>(); 

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public bool AddItem(Item item)
    {
        for(int i = 0; i < inventorySlots.Length; i++)
        {
            GameObject slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if(itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                Debug.Log("Item Spawned");
                return true;
            }
        }

        return false;
    }

    public void SpawnNewItem(Item item, GameObject slot)
    {
        GameObject newItem = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItem.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
    }

    public void UseItem()
    {
        if (InventoryUI.instance.currentItem == null)
        {
            Debug.Log("No item selected");
            return;
        }
            currentItem = InventoryUI.instance.currentItem.item;
            itemInUse = true;

            InventoryUI.instance.CloseExaminePanel();
        InventoryUI.instance.CloseInventory();
        Debug.Log("Using item: " + currentItem.itemName);
    }

    public void CombineItem()
    {
        if (InventoryUI.instance.currentItem == null)
            return;

        currentItem = InventoryUI.instance.currentItem.item;

        if(currentItem.actionType != ActionType.Combine)
        {
            Debug.Log("Item can't be combined");
        }

        itemInCombineMode = true;
        Debug.Log("Combine items");
    }

    public void RemoveItem(Item item)
    {
        foreach (GameObject slot in inventorySlots)
        {
            InventoryItem invItem = slot.GetComponentInChildren<InventoryItem>();
            if (invItem != null && invItem.item == item)
            {
                Destroy(invItem.gameObject);
                return;
            }
        }
    }


}
