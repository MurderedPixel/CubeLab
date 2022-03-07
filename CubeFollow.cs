using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFollow : MonoBehaviour{

    private GameObject player;
    private bool faceRight;

    void Start(){
        player = GameObject.Find("player");
    }

    void Update(){
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            faceRight = true;
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            faceRight = false;
        }

        if(faceRight == true){
            this.transform.position = new Vector3(player.transform.position.x + 1f, player.transform.position.y, player.transform.position.z);
        }
        else if(faceRight == false){
            this.transform.position = new Vector3(player.transform.position.x - 1f, player.transform.position.y, player.transform.position.z);
        } 
    }
}
