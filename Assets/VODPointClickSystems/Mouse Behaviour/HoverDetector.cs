using UnityEngine;
using TMPro;

public class HoverDetector : MonoBehaviour
{
    public static HoverDetector instance;

    Camera cam;
    HoverInfo currentHover;
    public TextMeshProUGUI hoverTextUI;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        cam = Camera.main;
        hoverTextUI.text = "";

        Cursor.visible = true;
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void ShowHoverText(string message)
    {
        gameObject.SetActive(true);
        hoverTextUI.text = message;
    }
    public void ClearHover()
    {
        if (currentHover != null)
        {
            currentHover = null;
            hoverTextUI.text = string.Empty;
        }
        gameObject.SetActive(false);
    }
}