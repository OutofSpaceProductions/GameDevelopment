using UnityEngine;
using System.Collections;

public class HealthTracker : MonoBehaviour {


	Vector2 point;
	private GameObject target;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player");
	}

	void Update () 
	{
		point = Camera.main.WorldToScreenPoint(target.transform.position);
		transform.position = point;
	}
}
