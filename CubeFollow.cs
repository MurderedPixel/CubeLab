using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//THIS SCRIPT IS FOR THE FUCKING PLACEHOLDER
public class CubeFollow : MonoBehaviour{

    public Sprite cantDropSprite;
    public Sprite originalSprite;
    public GameObject cube;
    public SpriteRenderer thisSR;
    public BoxCollider2D thisCollider2D;
    private GameObject player;
    private bool faceRight = true;
    public bool canDrop = true;
    private float distance = 1.0625f;

    void Start(){
        player = GameObject.Find("player");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("FullBarrier")) {
            thisCollider2D.size = new Vector2(1.3f, 0.9f);
        }
        if (other.CompareTag("ground") || other.CompareTag("FullBarrier")) {
            canDrop = false;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("FullBarrier")) {
            thisCollider2D.size = new Vector2(0.9f, 0.9f);
        }
        if (other.CompareTag("ground") || other.CompareTag("FullBarrier")) {
            canDrop = true;
        }
    }


    void Update(){
        //Moving the placeholder
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            faceRight = true;
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            faceRight = false;
        }

        if(canDrop == false) {
            thisSR.sprite = cantDropSprite;
        }
        if(canDrop == true) {
            thisSR.sprite = originalSprite;
        }

        //actual code
        if(faceRight == true){
            this.transform.position = new Vector3(player.transform.position.x + distance, player.transform.position.y, player.transform.position.z);
        }
        else if(faceRight == false){
            this.transform.position = new Vector3(player.transform.position.x - distance, player.transform.position.y, player.transform.position.z);
        }

        if(canDrop == true) {
            //spawning da cube
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)) {
                Instantiate(cube, this.transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }
        //put boxcast here, yes it will be a pain in the ass
    }
}
