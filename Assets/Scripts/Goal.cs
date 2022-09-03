using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject pauseMenu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            PauseMenu.IsPaused = true;
            Debug.Log("GAME WON!");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }
   
}
