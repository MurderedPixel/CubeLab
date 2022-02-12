using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertGravityTrigger : MonoBehaviour
{
    private GameObject player;

    private void Awake() 
    {
        player = GameObject.Find("player");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            other.attachedRigidbody.gravityScale = -1f;
            player.GetComponent<PlayerMovement>().reversedGravity = true;
        }
        if(other.CompareTag("cube"))
        {
            other.attachedRigidbody.gravityScale = -1f;
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            other.attachedRigidbody.gravityScale = 1f;
            player.GetComponent<PlayerMovement>().reversedGravity = false;
        }
        if(other.CompareTag("cube"))
        {
            other.attachedRigidbody.gravityScale = 1f;
        }
    }
}
