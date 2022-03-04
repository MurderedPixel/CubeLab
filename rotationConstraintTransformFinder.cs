using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class rotationConstraintTransformFinder : MonoBehaviour
{
    private Transform theTransform;
    public RotationConstraint theConstraint;
    private ConstraintSource source;

    void Awake() 
    {
        theTransform = GameObject.Find("GameManager").GetComponent<Transform>();
        source.sourceTransform = theTransform;
        source.weight = 1f;
        theConstraint.AddSource(source);
    }
}
