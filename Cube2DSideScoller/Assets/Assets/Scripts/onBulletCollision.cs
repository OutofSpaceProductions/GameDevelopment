using UnityEngine;
using System.Collections;

public class onBulletCollision : MonoBehaviour {

	public GameObject DeathParticales;

	void OnCollsion2D (Collision2D other) 
	{
		if(other.gameObject.tag == "Bullet")
		{
			Instantiate(DeathParticales, transform.position, transform.rotation);
		}
	}
}
