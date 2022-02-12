using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchTrigger : MonoBehaviour
{
    public GameObject gate;
    public GameObject lightSource;
    public SpriteRenderer spriteRenderer;
    public bool isActive = false;
    public bool isLighSwitch = false;
    public bool isLever = true;
    public bool updateActivated = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            updateActivated = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            updateActivated = false;
        }
    }

    void Update()
    {
        if(updateActivated == true)
        {

            if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                isActive = !isActive;

                if(isActive == false)
                {
                    if(isLever == true)
                    {
                        spriteRenderer.flipY = true;
                        gate.GetComponent<gateController>().Opening();
                    }

                    if(isLighSwitch == true)
                    {
                        lightSource.SetActive(true);
                    }
                }

                if(isActive == true)
                {
                    if(isLever == true)
                    {
                        spriteRenderer.flipY = false;
                        gate.GetComponent<gateController>().Closing();
                    }

                    if(isLighSwitch == true)
                    {
                        lightSource.SetActive(false);
                    }
                }
            
            }
        }

    }
    
}
