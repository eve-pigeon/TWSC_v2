using UnityEngine;

public class NavigationManager : MonoBehaviour
{
    public GameObject currentView;
    public GameObject viewToToggle;
    public GameObject newViewToggle;

    private bool isNewView;

    public void SetNewView()
    {
        currentView.SetActive(false);

        if (!isNewView)
        {
            viewToToggle.SetActive(true);
        }
        else
        {
            newViewToggle.SetActive(true);
        }

        HoverDetector.instance.ClearHover();
    }

    public void ChangeView()
    {
        isNewView = true;
    }
}
