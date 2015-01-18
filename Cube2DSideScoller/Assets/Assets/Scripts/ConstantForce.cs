using UnityEngine;
using System.Collections;

public class ConstantForce : MonoBehaviour {

	public float force = 1;
	public bool XForce = true;

	void Update () 
	{
		if(XForce == true)
		{
			transform.position += new Vector3(force * Time.deltaTime, 0, 0);
		}
		else
		{
			transform.position += new Vector3(0, force * Time.deltaTime, 0);
		}
	}
}
