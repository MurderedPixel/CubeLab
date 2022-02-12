using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    bool gameHasEnded = false;
    public bool isPaused = false;
    public bool nonChamber = false;
    public bool negativeSec = false;
    public float restartDelay = 0.5f;
    public menuButton menuButtonScript;
    public GameObject gameComplete;
    public GameObject gameOver;
    private Vector2 invertedGravity = new Vector2(0f, 30f);
    private GameObject pauseMenuObject;
    private GameObject pauseMenuButton;
    private GameObject player;
    private GameObject canvas;


    private void Awake() 
    {
        canvas = GameObject.Find("Canvas");
        player = GameObject.Find("player");
        pauseMenuButton = canvas.transform.Find("pauseMenuButtonUI").gameObject;
        pauseMenuObject = canvas.transform.Find("pauseMenu").gameObject;
        gameComplete = canvas.transform.Find("leveldone").gameObject;
        gameOver = canvas.transform.Find("gameover").gameObject;
        menuButtonScript = pauseMenuObject.GetComponent<menuButton>();

        //negative section rules
        if(negativeSec == true)
        {
            Physics2D.gravity = invertedGravity;
            player.GetComponent<PlayerMovement>().reversedGravity = true;
        }
        else if(negativeSec == false)
        {
            Physics2D.gravity = new Vector2(0f, -30f);
            player.GetComponent<PlayerMovement>().reversedGravity = false;
        }
        

        if(nonChamber == true)
        {
            canvas.transform.Find("leveldone/CompletedText").gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            menuButtonScript.PauseMenu();
        }

        if(Input.GetKeyDown(KeyCode.F11))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }

        //DEBUG FEATURES
        if(Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        if(Input.GetKeyDown(KeyCode.F2))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if(Input.GetKeyDown(KeyCode.F5))
        {
            player.GetComponent<Rigidbody2D>().gravityScale += 0.1f;
            Debug.Log(player.GetComponent<Rigidbody2D>().gravityScale.ToString());
        }

        if(Input.GetKeyDown(KeyCode.F6))
        {
            player.GetComponent<Rigidbody2D>().gravityScale -= 0.1f;
            Debug.Log(player.GetComponent<Rigidbody2D>().gravityScale.ToString());
        }
        //END OF DEBUG FEATURES
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
            gameOver.SetActive(true);
        }
    }

    public void Finish()
    {
        FindObjectOfType<PlayerMovement>().enabled = false;
        Invoke("NextLevel", restartDelay);
        gameComplete.SetActive(true);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
