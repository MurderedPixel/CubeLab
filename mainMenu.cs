using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject mMenu;
    public GameObject boutPage;
    public GameObject settingsMenu;
    public GameObject levelSelectMenu;
    public GameObject thisPage;
    public GameObject logo;

  public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level00");
    }

  public void LevelSelect()
    {
        mMenu.SetActive(false);
        levelSelectMenu.SetActive(true);
        logo.SetActive(false);
    }

  public void Settings()
    {
        mMenu.SetActive(false);
        settingsMenu.SetActive(true);
        logo.SetActive(false);
    }

  public void QuitGame()
    {
        Application.Quit();
    }

  public void AboutGame()
    {
        mMenu.SetActive(false);
        boutPage.SetActive(true);
        logo.SetActive(false);
    }
  public void backToTheMenu()
    {
        thisPage.SetActive(false);
        mMenu.SetActive(true);
        logo.SetActive(true);
    }
}
