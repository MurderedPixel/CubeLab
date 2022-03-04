using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class lastLevelUI : MonoBehaviour
{
    public int lastLevel;
    public TextMeshProUGUI lastLevelText;

    void Awake()
    {
        lastLevel = PlayerPrefs.GetInt("lastLevel");
        lastLevelText.text = lastLevel.ToString();

    }
}
