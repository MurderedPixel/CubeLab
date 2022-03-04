using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public SpriteRenderer spriteRenderer;
    public Sprite deadPlayerSprite;
    public ParticleSystem deathEffect;
    public GameObject playerSpriteLight;
    public GameObject playerLight;
    public float deathDelay;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            die();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("obstacle"))
        {
            die();
        }

        if(other.CompareTag("stickyWall"))
        {
            rb.gravityScale = 0.1f;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("stickyWall"))
        {
            rb.gravityScale = 1f;
        }
    }

    void deadSprite()
    {
        spriteRenderer.sprite = deadPlayerSprite;
    }

    void death()
    {
        FindObjectOfType<GameManager>().EndGame();
    }

    void dying()
    {
        deathEffect.Play();
        deadSprite();
        movement.enabled = false;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        playerLight.SetActive(false);
        playerSpriteLight.SetActive(false);
    }

    public void die()
    {
        dying();
        Invoke("death", deathDelay);
    }
}
