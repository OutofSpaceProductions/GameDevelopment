﻿using UnityEngine;
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
	public GameObject Bullet;

	public float FireDelay = 1.0f;
	float lastTap = 0.0f;
	
	GameManager gameManager;
	void Start()
	{
		orignalPlace = transform.position;
		GameObject gameManagerScript = GameObject.FindGameObjectWithTag("GameController");
		gameManager = gameManagerScript.GetComponent<GameManager>();
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
				lastTap = 0.0f;
				rigidbody2D.AddForce(new Vector2(0, jumpForce));
				doubleJumped = false;
				jumpTimer = 0.0f;
			}
			else if (!doubleJumped && jumpTimer > minJumpTime)
			{
				rigidbody2D.AddForce(new Vector2(0, jumpForce * 5));
				doubleJumped = true;
			}
		}
		lastTap += Time.deltaTime;
		if(Input.touchCount == 2 && lastTap > FireDelay)
		{
			lastTap = 0;
			Shoot();
		}
	}

	void Shoot()
	{
		Instantiate(Bullet, transform.position, Bullet.transform.rotation);
	}

	IEnumerator Teleport()
	{
		Instantiate(Bullet, transform.position, transform.rotation);
		yield return new WaitForSeconds(1);
		Debug.Log("Ending");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.tag == "Destroy")
		{
			gameManager.Dead();
		}
	}

}
