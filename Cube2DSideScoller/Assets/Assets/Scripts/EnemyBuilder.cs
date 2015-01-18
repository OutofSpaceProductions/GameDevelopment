using UnityEngine;
using System.Collections;

public class EnemyBuilder : MonoBehaviour {
	

	public GameObject Enemy;
	public Transform EnemyPoint;

	void Start () 
	{
		InvokeRepeating("BuildEnemies", 1, 1);
	}
	
	// Update is called once per frame
	void BuildEnemies () 
	{
		Instantiate(Enemy, EnemyPoint.position, EnemyPoint.rotation);
	}
}
