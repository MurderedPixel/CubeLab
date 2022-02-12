using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelector : MonoBehaviour
{
    public int levelIndex;
    public TextMeshProUGUI buttonText;

    private void Awake()
    {
        buttonText.text = levelIndex.ToString();
    }


    public void Click()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + levelIndex);
    }
}
