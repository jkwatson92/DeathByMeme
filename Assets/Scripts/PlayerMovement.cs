using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rbody;
	Animator anim;
	
	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 movement_V = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		if (movement_V != Vector2.zero) {
			anim.SetBool("Is_walking", true);
            anim.SetFloat("Input_x", movement_V.x);
            anim.SetFloat("Input_y", movement_V.y);
		} else {
			anim.SetBool("Is_walking", false);
		}
		
        rbody.MovePosition(rbody.position + movement_V * Time.deltaTime * 70.0f);
	}
}
