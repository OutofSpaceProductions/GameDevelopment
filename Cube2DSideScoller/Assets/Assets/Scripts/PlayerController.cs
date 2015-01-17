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
	Vector2 orignalPlace;
	public float touchDelay = 1.0f;
	public int tapCount = 1;


	public float doubleTapDelay = 0.1f;
	int count = 0;
	

	void Start()
	{
		orignalPlace = transform.position;
	}

	void Update () 
	{
		transform.position = new Vector2(orignalPlace.x, transform.position.y);
		grounded = Physics2D.OverlapCircle(GroundCheck.transform.position, GroundCheckRadius, WhatIsGround);
		if(grounded)
		{
			doubleJumped = false;
		}

		jumpTimer += Time.deltaTime;

		if(Input.touchCount == 1)
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
			if(Input.touchCount == 1)
			{
				float t = 0.0f;
				while(t < doubleTapDelay)
				{
					t += Time.deltaTime;
					if(Input.touchCount == 1)
					{
					Debug.Log("Double");
					}
				}
			}
		if(Input.touchCount == 2)
		{
			StartCoroutine(Teleport());
		}
	}

	IEnumerator Teleport()
	{
		Debug.Log("Beging");
		yield return new WaitForSeconds(1);
		Debug.Log("Ending");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.tag == "Destroy")
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}

}
