using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateController : MonoBehaviour
{
    public bool isOpen;
    private Collider2D thisCollider;
    private Animator anim;

    void Awake()
    {
        thisCollider = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
    }

    public void Closing()
    {

        if(isOpen == true)
        {
            thisCollider.enabled = true;
            anim.SetInteger("decider", 1);
            isOpen = false;
        }
    }

    public void Opening()
    {
        if(isOpen == false)
        {
            thisCollider.enabled = false;
            anim.SetInteger("decider", 2);
            isOpen = true;
        }
    }
}
