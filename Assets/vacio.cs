using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vacio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Muere");
        if (col.transform.tag == "player")
        {

            Application.Quit();
        }
    }
}
