using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public GameObject pauseMenu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((!collision.CompareTag("Finish")) && (!collision.CompareTag("Coins")))
        {
            //if head colides with ground - restart the level
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            PauseMenu.IsPaused = true;
        }
    }
}
