using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textDisabler : MonoBehaviour
{
    public GameObject inGameText = GameObject.Find("inGameText");

    private void OnTriggerEnter2D()
    {
        inGameText.SetActive(false);
    }
}
