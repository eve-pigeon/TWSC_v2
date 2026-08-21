using UnityEngine;

public class HoverInfo : MonoBehaviour
{
    [TextArea]
    public string hoverText;

    private void OnMouseEnter()
    {
        //if (InventoryUI.instance.isInventoryOpen)
        //{
        //    HoverDetector.instance.ClearHover();
        //}
        //else
        //{
        //    HoverDetector.instance.ShowHoverText(hoverText);
        //}

        HoverDetector.instance.ShowHoverText(hoverText);
    }

    private void OnMouseExit()
    {
        HoverDetector.instance.ClearHover();
    }
}