using UnityEngine;
using DialogueEditor;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private NPCConversation dialogue;

    public bool disableDialogue;

    public void StartDialogue()
    {
        if (ConversationManager.Instance.DialoguePanel.gameObject.activeInHierarchy)
        {
            Debug.Log("Dialogue already occurring");
        }
        else if (disableDialogue)
        {
            return;
        }
        else
        {
            ConversationManager.Instance.StartConversation(dialogue);
        }
    }

    public void DisableDialogue()
    {
        disableDialogue = true;
        ConversationManager.Instance.DialoguePanel.gameObject.SetActive(false);
    }
}
