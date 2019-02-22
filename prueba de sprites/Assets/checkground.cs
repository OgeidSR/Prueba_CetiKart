using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkground : MonoBehaviour
{
    private molina coco;

    // Use this for initialization
    void Start()
    {
        coco = GetComponentInParent<molina>();

    }

    void OnCollisionStay2D(Collision2D col)
    {
       coco.grounder2 = true;

    }

    void OnCollisionExit2D(Collision2D col)
    {
        coco.grounder2 = true;

    }

}