using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume ()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    public void Pause ()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void LoadMenu(string sceneName)
    {
        IsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }

    public void NextLevel(string sceneName)
    {
        IsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }

    public void Restart(string sceneName)
    {
        IsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
