using UnityEngine;
using UnityEngine.Events;

public class CutsceneTrigger : MonoBehaviour
{
    public UnityEvent startDialogue;

    private void Start()
    {
        startDialogue.Invoke();
    }
}
