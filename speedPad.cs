using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedPad : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedForce = 30f;
    public float altBoostForce = 0f;

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        rb = collisionInfo.rigidbody;
        rb.AddForce(new Vector2(speedForce, altBoostForce), ForceMode2D.Impulse);
    }
}
