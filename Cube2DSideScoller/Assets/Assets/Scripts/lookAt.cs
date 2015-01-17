using UnityEngine;
using System.Collections;

public class lookAt : MonoBehaviour {

	public Transform target;

	void Update () 
	{
		transform.LookAt(target.position);
	}
}
