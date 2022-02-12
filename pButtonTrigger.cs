using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pButtonTrigger : MonoBehaviour
{
    public GameObject gate;
    public SpriteRenderer spriteRenderer;
    public Sprite none;
    public Sprite original;
    public bool gateButton = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(gateButton == true)
            {
                gate.GetComponent<gateController>().Opening();
                spriteRenderer.sprite = none;
            }

            else if(gateButton == false)
            {
                gate.SetActive(false);
                spriteRenderer.sprite = none;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(gateButton == true)
            {
                gate.GetComponent<gateController>().Closing();
                spriteRenderer.sprite = original;
            }

            else if(gateButton == false)
            {
                gate.SetActive(true);
                spriteRenderer.sprite = original;
            }
        }
        
    }
}

