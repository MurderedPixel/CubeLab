using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFollow : MonoBehaviour{

    public GameObject cube;
    private GameObject player;
    private bool faceRight = true;
    public bool overlap = false;

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
            this.transform.position = new Vector3(player.transform.position.x + 1.0625f, player.transform.position.y, player.transform.position.z);
        }
        else if(faceRight == false){
            this.transform.position = new Vector3(player.transform.position.x - 1.0625f, player.transform.position.y, player.transform.position.z);
        }

        if(Input.GetKeyUp(KeyCode.E) || Input.GetKeyUp(KeyCode.Mouse0)){
            Instantiate(cube, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
