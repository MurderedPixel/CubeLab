using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreCollision : MonoBehaviour
{
    private Collider2D PlayerObject;
    public Collider2D thisCollider;
    public string ignoredTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerObject = other.gameObject.GetComponent<Collider2D>();

        if (other.CompareTag(ignoredTag))
        {
            Physics2D.IgnoreCollision(thisCollider, PlayerObject);
        }
    }

}
