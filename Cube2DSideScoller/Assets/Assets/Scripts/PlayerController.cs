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
	
		if(Input.GetMouseButton(0))
		{
			if(grounded)
			{
				rigidbody2D.AddForce(new Vector2(0, jumpForce));
				AbleToJump = 1;
				Debug.Log("Jump 1");
			}
			else if(Input.GetMouseButtonDown(0))
			{
				if (AbleToJump == 1)
				{
					float newJumpForce = jumpForce * 2;
					rigidbody2D.AddForce(new Vector2(0, newJumpForce));
					AbleToJump = 0;
					Debug.Log("Jump 2");
				}
			}
		}
		if(grounded)
		{
			AbleToJump = 2;
		}



	}

}
