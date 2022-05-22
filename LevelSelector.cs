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
        int sceneToBeLoaded = SceneManager.GetActiveScene().buildIndex + levelIndex;
        if(NameFromIndex(sceneToBeLoaded) != "levelDebug"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + levelIndex);
        }
    }

    //From a friendly guy at Unity forums! Thanks  JimmyCushnie
    private static string NameFromIndex(int BuildIndex){
        string path = SceneUtility.GetScenePathByBuildIndex(BuildIndex);
        int slash = path.LastIndexOf('/');
        string name = path.Substring(slash + 1);
        int dot = name.LastIndexOf('.');
        return name.Substring(0, dot);
    }
}
