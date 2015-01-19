using UnityEngine;
using System.Collections;

public class moveToGameSpeed : MonoBehaviour {

	GameManager gameManager;



	// Use this for initialization
	void Start () 
	{
		GameObject gameManagerScript = GameObject.FindGameObjectWithTag("GameController");
		gameManager = gameManagerScript.GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += new Vector3(gameManager.AverageSpeed,0f, 0f) * Time.deltaTime;
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.tag == "Destroy")
		{
			Destroy(this.gameObject);
		}
	}
}
