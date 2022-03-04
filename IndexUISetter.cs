using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class IndexUISetter : MonoBehaviour
{
    public int levelIndex;
    public int lastLevel;
    public TextMeshProUGUI indexText;

    void Awake()
    {
        levelIndex = SceneManager.GetActiveScene().buildIndex;
        indexText.text = levelIndex.ToString();
        PlayerPrefs.SetInt("lastLevel", levelIndex);
        PlayerPrefs.Save();
    }
}
