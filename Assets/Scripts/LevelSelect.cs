using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void SwithLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
