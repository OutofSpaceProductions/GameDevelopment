using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpForce = 1.0f;
	public LayerMask WhatIsGround;
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public float minJumpTime = 1f;
	bool grounded = false;
	bool doubleJumped = false;
	private float jumpTimer = 0.0f;
	// Update is called once per frame
	void Update () 
	{
		grounded = Physics2D.OverlapCircle(GroundCheck.transform.position, GroundCheckRadius, WhatIsGround);
		if(grounded)
		{
			doubleJumped = false;
		}

		jumpTimer += Time.deltaTime;

		if(Input.GetMouseButton(0))
		{
			if(grounded)
			{
				rigidbody2D.AddForce(new Vector2(0, jumpForce));
				doubleJumped = false;
				Debug.Log("Jump1");
				jumpTimer = 0.0f;
			}
			else if (!doubleJumped && jumpTimer > minJumpTime)
			{
				rigidbody2D.AddForce(new Vector2(0, jumpForce * 5));
				doubleJumped = true;
				Debug.Log("Jump2");

			}
		}
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.tag == "Destroy")
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}

}
