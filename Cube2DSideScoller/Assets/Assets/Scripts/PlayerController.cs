using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpForce = 1.0f;
	public LayerMask WhatIsGround;
	public Transform GroundCheck;
	public float GroundCheckRadius;
	bool grounded = false;
	int AbleToJump = 2;
	// Update is called once per frame
	void Update () 
	{
		grounded = Physics2D.OverlapCircle(GroundCheck.transform.position, GroundCheckRadius, WhatIsGround);
		Debug.Log(grounded);
		if(grounded)
		{
			AbleToJump = 2;
		}

		if(Input.GetMouseButtonDown(0) && grounded)
		{
			if(AbleToJump == 2)
			{
				rigidbody2D.AddForce(new Vector2(0, jumpForce));
				AbleToJump = 1;
			}
		}
		if(Input.GetMouseButtonDown(0) && grounded == false)
		{
			if (AbleToJump == 1)
			{
				float newJumpForce = jumpForce * 2;
				rigidbody2D.AddForce(new Vector2(0, newJumpForce));
				AbleToJump = 0;
			}
		}
		Debug.Log(AbleToJump);


	}

}
