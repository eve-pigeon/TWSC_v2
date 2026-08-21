using UnityEngine;
using UnityEngine.Events;

public class RequiresItem : MonoBehaviour
{
    public Item requiredItem;
    public bool consumeItem;

    [SerializeField] private UnityEvent function;

    public void TryUseItem(Item usedItem)
    {
        if (usedItem == requiredItem)
        {
            if (consumeItem)
            {
                Destroy(InventoryUI.instance.currentItem.gameObject);
            }

            function.Invoke();
        }
        else
        {
            Debug.Log("Wrong item.");
        }
    }
}
