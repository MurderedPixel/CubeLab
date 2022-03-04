using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateAnimation : MonoBehaviour
{
    public GameObject thisObject;
    private Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update() 
    {
        if(thisObject.activeSelf == true)
        {
            animator.SetBool("isTurnedOn", true);
        }

        else if(thisObject.activeSelf == false)
        {
            animator.SetBool("isTurnedOn", false);
        }
    }
}
