using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class molina : MonoBehaviour
{
    public float maxSpeed2 = 5f;
    public float speed2 = 2f;
    public bool grounder2;
    private Rigidbody2D molina2;
    private Animator anim2;
    public float jumpPower2 = 1f;
    private bool jump2;

    // Use this for initialization
    void Start()
    {
        molina2 = GetComponent<Rigidbody2D>();
        anim2 = GetComponent<Animator>();
        grounder2 = true;

    }
    void Update()
    {
        anim2.SetFloat("speed", Mathf.Abs(molina2.velocity.x));
        anim2.SetBool("grounder", grounder2);

        if (CrossPlatformInputManager.GetButton("Jump") && grounder2)
        {
            jump2 = true;
        }
    }

    void FixedUpdate()
    {

        float h = CrossPlatformInputManager.GetAxis("Horizontal");

        molina2.AddForce(Vector2.right * speed2 * h);

        float limitedSpeed = Mathf.Clamp(molina2.velocity.x, -maxSpeed2, maxSpeed2);
        molina2.velocity = new Vector2(limitedSpeed, molina2.velocity.y);

        if (jump2)
        {
            molina2.AddForce(Vector2.up * jumpPower2, ForceMode2D.Impulse);
            jump2 = false;
            Debug.Log(grounder2);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.transform.tag);
        if (col.transform.tag == "grounder" && !grounder2)
        {
            Debug.Log("Collision suelo");
            grounder2 = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        Debug.Log(col.transform.tag);
        if (col.transform.tag == "grounder" && grounder2)
        {
            Debug.Log("Collision salida suelo");
            grounder2 = false;
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log(col.transform.tag);
        if (col.transform.tag == "grounder" && !grounder2)
        {
            Debug.Log("Collision suelo");
            grounder2 = true;
        }
    }
}
