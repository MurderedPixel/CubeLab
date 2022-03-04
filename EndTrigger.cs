using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().Finish();
            other.attachedRigidbody.velocity = new Vector2(0, 0);
        }
    }
}
