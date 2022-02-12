using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    public GameObject gate;
    public GameObject lightSource;
    public SpriteRenderer spriteRenderer;

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player") && Input.GetKey(KeyCode.Mouse0) || other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            spriteRenderer.flipY = true;
            gate.SetActive(false);
            lightSource.SetActive(true);
        }
    }
}
