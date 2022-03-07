using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabCube : MonoBehaviour
{
    public GameObject replacement;
    private Transform thisTransform;
    private Transform playerTransform;
    private bool grabbable = false;

    void Start(){
        thisTransform = transform.parent.transform;
        playerTransform = GameObject.Find("player").transform;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            grabbable = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.tag == "Player"){
            grabbable = false;
        }
    }

    void Update(){
        if(grabbable == true){
            if(Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Mouse0)){
                Vector3 currentTransform = thisTransform.position;
                Instantiate(replacement, new Vector3(playerTransform.position.x + 1.0625f, playerTransform.position.y, playerTransform.position.z), Quaternion.identity);
                Destroy(thisTransform.gameObject);
            }
        }
    }
}
