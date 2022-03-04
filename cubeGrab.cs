using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGrab : MonoBehaviour
{
    public Transform playerTrans;
    public Transform meTrans;
    public SpriteRenderer spriteRenderer;
    public Sprite originalSprite ;
    public Sprite pickableSprite;
    public Collider2D cubeCollider;
    private bool canDestroy = false;

    private void Start()
    {
        playerTrans = GameObject.Find("player").transform;
        meTrans = transform.parent.transform;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && spriteRenderer.sprite == originalSprite)
        {
            ChangeSprite(pickableSprite);
            if(canDestroy == false){canDestroy = true;}

            while(canDestroy == true) {
                while(Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Mouse0)) {
                    meTrans.gameObject.GetComponent<Collider2D>().enabled = false;
                    meTrans.position = new Vector2(playerTrans.position.x + 1f, playerTrans.position.y);
                }
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player" && spriteRenderer.sprite == pickableSprite)
        {
           ChangeSprite(originalSprite);
           if(canDestroy == true){canDestroy = false;}
        }
    }
/*
    private void Update() 
    {
        if(canDestroy == true)
        {
            if(Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Mouse0))
            {
                meTrans.gameObject.GetComponent<Collider2D>().enabled = false;
                meTrans.position = new Vector2(playerTrans.position.x + 1f, playerTrans.position.y);
            }
        }
        if(canDestroy == false) {
            meTrans.gameObject.GetComponent<Collider2D>().enabled = true;
        }
    }
*/

    //my own methods
    private void ChangeSprite(Sprite _newSprite)
    {
        spriteRenderer.sprite = _newSprite;
    }
}