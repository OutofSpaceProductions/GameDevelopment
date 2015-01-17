using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	GameObject target;
	public float yMin;
	public float yMax;
	
	Quaternion rotation;
	void Start()
	{
		rotation = Quaternion.identity;
		target = GameObject.FindGameObjectWithTag("Player");
	}

	void Update () 
	{
		transform.rotation = rotation;
		if(target.transform.position.x >= yMin)
		{
			transform.parent = target.transform;
		}
		else 
		{
			transform.parent = null;
		}
	}
}
