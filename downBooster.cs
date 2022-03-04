using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downBooster : MonoBehaviour
{
    public float downBoostForce = 50f;
    private Rigidbody2D rb;

    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector2(0, -downBoostForce));
        }
    }
}
