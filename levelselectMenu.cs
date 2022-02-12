using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelselectMenu : MonoBehaviour
{
    public string sceneName = "level01";

    public void SelectLevel()
    {
        SceneManager.LoadScene(sceneName);
    }
}
