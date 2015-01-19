using UnityEngine;
using System.Collections;

public class onBulletCollision : MonoBehaviour {

	public GameObject DeathParticales;

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.tag == "Bullet")
		{
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
	}
}
