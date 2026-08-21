using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] private string sceneName;
    private Scene currentScene;

    public void GoToScene()
    {
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
        currentScene = SceneManager.GetSceneByName(sceneName);
        HoverDetector.instance.ClearHover();
    }
}
