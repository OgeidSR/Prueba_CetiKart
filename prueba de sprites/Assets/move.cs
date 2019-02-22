using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class move : MonoBehaviour {
    public float maxSpeed = 5f;
    public float speed = 2f;
    public bool grounder;
    private Rigidbody2D coco;
    private Animator anim;
    public float jumpPower = 6.5f;
    private bool jump;

	// Use this for initialization
	void Start () {
        coco = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
		
	}
    void Update() {
        anim.SetFloat("speed", Mathf.Abs(coco.velocity.x));
        anim.SetBool("grounder", grounder);

        if (CrossPlatformInputManager.GetButton("Jump") && grounder){
            jump = true;
        }
    }

	void FixedUpdate () {
       float h = CrossPlatformInputManager.GetAxis("Horizontal");

        coco.AddForce(Vector2.right * speed * h);

        float limitedSpeed = Mathf.Clamp(coco.velocity.x, -maxSpeed, maxSpeed);
        coco.velocity = new Vector2(limitedSpeed, coco.velocity.y);

        if (jump) {
            coco.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }
	}
}

 /*Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")*moveForce);
        bool saltar = CrossPlatformInputManager.GetButton("Jump");
        Debug.Log(saltar ? jump : 1);
        coco.AddForce(moveVec * (saltar ? jump : 1));*/
		