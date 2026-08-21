using UnityEngine;
using UnityEngine.InputSystem;
//using DialogueEditor;

public class InputHandler : MonoBehaviour
{
    public static InputHandler instance;

    private Camera mainCamera;

    //[SerializeField] private NPCConversation wrongItemDialogue;

    private void Awake()
    {
        mainCamera = Camera.main;

        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        Cursor.lockState = CursorLockMode.Confined;
    }
    

    //public void OnClick(InputAction.CallbackContext context)
    //{
    //    if (ConversationManager.Instance.DialoguePanel.gameObject.activeInHierarchy)
    //    {
    //        Debug.Log("Dialogue active, cannot click");
    //    }
    //    else
    //    {
    //        if (!context.started) return;

    //        Vector2 mousePosition = Mouse.current.position.ReadValue();
    //        Ray ray = mainCamera.ScreenPointToRay(mousePosition);

    //        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
    //        if (!hit.collider) return;

    //        // if an item is in use, try to use it
    //        if (InventoryManager.instance.itemInUse)
    //        {
    //            RequiresItem target = hit.collider.GetComponent<RequiresItem>();

    //            if (target != null)
    //            {
    //                target.TryUseItem(InventoryManager.instance.currentItem);
    //                Debug.Log("Used item!");
    //            }
    //            else
    //            {
    //                Debug.Log("Doesn't use this item");
    //                ConversationManager.Instance.StartConversation(wrongItemDialogue);
    //            }

    //            InventoryManager.instance.itemInUse = false;
    //            return;
    //        }

    //        //if raycast hits an item with dialogue attached
    //        DialogueTrigger dialogueTrigger = hit.collider.GetComponent<DialogueTrigger>();
    //        if (dialogueTrigger != null)
    //        {
    //            dialogueTrigger.StartDialogue();
    //            Debug.Log("Dialogue triggered");
    //        }

    //        //if raycast hits navigation trigger, change view
    //        NavigationManager navigation = hit.collider.GetComponent<NavigationManager>();
    //        if (navigation != null)
    //        {
    //            navigation.SetNewView();
    //        }

    //        SceneManagement sceneManagement = hit.collider.GetComponent<SceneManagement>();
    //        if (sceneManagement != null)
    //        {
    //            sceneManagement.GoToScene();
    //        }

    //        // otherwise, try picking up an item
    //        ItemPickup pickupItem = hit.collider.GetComponent<ItemPickup>();
    //        if (pickupItem != null)
    //        {
    //            pickupItem.PickUpItem();
    //        }
    //    }
    //}
}
