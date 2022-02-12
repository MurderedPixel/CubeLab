using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuButton : MonoBehaviour
{
    public GameObject pauseMenuObject;
    public GameObject pauseMenuButton;
    public GameObject player;
    public GameManager gameManager;
    public bool isPaused = false;

    public void Awake() 
    {
        player = GameObject.Find("player");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void PauseMenu()
    {
        isPaused = !isPaused;

        if(isPaused == true)
        {
            pauseMenuObject.SetActive(true);
            pauseMenuButton.SetActive(false);
            player.SetActive(false);
            Time.timeScale = 0f;
        }

        if(isPaused == false)
        {
            pauseMenuObject.SetActive(false);
            pauseMenuButton.SetActive(true);
            player.SetActive(true);
            Time.timeScale = 1f;
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
