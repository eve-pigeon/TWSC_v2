using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI instance;
    public GameObject inventoryPanel;

    public InventoryItem currentItem;

    public bool isInventoryOpen;

    [Header("Examine UI")]
    public GameObject examinePanel;
    public TextMeshProUGUI examineNameTxt;
    public TextMeshProUGUI examineDescriptionTxt;
    public Image examineImage;

    [Header("Display UI")]
    public GameObject pickupDisplayPanel;
    public Image pickupImage;
    public TextMeshProUGUI pickupText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        CloseExaminePanel();
    }

    public void ShowPickupDisplay(Item item)
    {
        if(pickupDisplayPanel != null)
        {
            pickupDisplayPanel.SetActive(true);
            pickupText.text = "Picked up:" + item.itemName;
            pickupImage.sprite = item.icon;

            Invoke("EndPickupDisplay", 2f);
        }
    }

    private void EndPickupDisplay()
    {
        if(pickupDisplayPanel != null)
        {
            pickupDisplayPanel.SetActive(false);
        }
        else
        {
            Debug.Log("Text not found");
        }
    }

    public void OpenExaminePanel(Item item)
    {
        if(item != null)
        {
            examineNameTxt.text = item.itemName;
            examineDescriptionTxt.text = item.description;
            examineImage.sprite = item.icon;
            examinePanel.SetActive(true);
        }
        else
        {
            Debug.Log("There is no item");
        }
    }

    public void CloseExaminePanel()
    {
        examinePanel.SetActive(false);
    }

    public void OpenInventory()
    {
        isInventoryOpen = !isInventoryOpen;

        if (isInventoryOpen)
        {
            inventoryPanel.SetActive(true);
        }
        else
        {
            inventoryPanel.SetActive(false);
        }
    }

    public void CloseInventory()
    {
        inventoryPanel.SetActive(false);
        isInventoryOpen = false;
    }
}
