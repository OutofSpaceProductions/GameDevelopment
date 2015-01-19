using UnityEngine;
using System.Collections;

public class ConstantForce : MonoBehaviour {

	public float force = 1;
	public bool XForce = true;

	void Update () 
	{
		if(XForce == true)
		{
			transform.Translate(Vector3.right * force * Time.deltaTime);
		}
		else
		{
			transform.position += new Vector3(0, force * Time.deltaTime, 0);
		}
	}
}
