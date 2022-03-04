using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonTrigger : MonoBehaviour
{
    public GameObject gate;
    public SpriteRenderer spriteRenderer;
    public Sprite none;
    public Sprite original;
    public Sprite cubeOriginal;
    public Sprite cubeTurnedOn;
    public bool gateButton = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("cube"))
        {
            if(gateButton == true)
            {
                other.GetComponent<SpriteRenderer>().sprite = cubeTurnedOn;
                gate.GetComponent<gateController>().Opening();
                spriteRenderer.sprite = none;
            }

            else if(gateButton == false)
            {
                other.GetComponent<SpriteRenderer>().sprite = cubeTurnedOn;
                gate.SetActive(false);
                spriteRenderer.sprite = none;
            }

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("cube"))
        {
            if(gateButton == true)
            {
                other.GetComponent<SpriteRenderer>().sprite = cubeOriginal;
                gate.GetComponent<gateController>().Closing();
                spriteRenderer.sprite = original;
            }

            else if(gateButton == false)
            {
                other.GetComponent<SpriteRenderer>().sprite = cubeOriginal;
                gate.SetActive(true);
                spriteRenderer.sprite = original;
            }

        }
    }
}
