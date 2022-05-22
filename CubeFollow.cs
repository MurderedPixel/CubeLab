using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFollow : MonoBehaviour{

    public GameObject cube;
    public SpriteRenderer thisSR;
    private GameObject player;
    private Vector2 boxcastDirection;
    private bool faceRight = true;
    private float distance = 1.0625f;

    void Start(){
        player = GameObject.Find("player");
    }

    void Update(){
        //Moving the placeholder
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            faceRight = true;
            boxcastDirection = Vector2.right;
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            faceRight = false;
            boxcastDirection = Vector2.left;
        }
        if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.Mouse1)){
            distance = 2f;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.Mouse1)){
            distance = 1.0625f;
        }

        //actual code
        if(faceRight == true){
            this.transform.position = new Vector3(player.transform.position.x + distance, player.transform.position.y, player.transform.position.z);
        }
        else if(faceRight == false){
            this.transform.position = new Vector3(player.transform.position.x - distance, player.transform.position.y, player.transform.position.z);
        }

        //spawning da cube
        if(Input.GetKeyUp(KeyCode.E) || Input.GetKeyUp(KeyCode.Mouse0)){
            Instantiate(cube, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

        //put boxcast here, yes it will be a pain in the ass
    }
}
