using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour 
{
	public GameObject minus5;
	public GameObject plus5;
	public GameObject plus10;
	GameManager gameManager;

	void Start () 
	{
		GameObject gameManagerScript = GameObject.FindGameObjectWithTag("GameController");
		gameManager = gameManagerScript.GetComponent<GameManager>();
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Player")
		{
			ContactPoint2D contact = collision.contacts[0];
			Vector3 pos = contact.point;
			Instantiate(minus5, pos, minus5.transform.rotation);
			gameManager.Health(gameManager.MinorDamage);
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.tag == "Bullet")
		{
			gameManager.DestroyedEnemy(gameManager.KillEnemyValue);
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
	}

}
