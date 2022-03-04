using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billyDance : MonoBehaviour
{
    public float speed = 1f;
    public float distanceCoordY = 5f;
    public float distanceCoordX = 0f;
    private float startCoordY;
    private float startCoordX;
    public void Start()
    {
        startCoordY = transform.position.y;
        startCoordX = transform.position.x;
    }

    public void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) * distanceCoordY + startCoordY;
        float x = Mathf.PingPong(Time.time * speed, 1) * distanceCoordX + startCoordX;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
