using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public float AverageSpeed = 1.0f;
	public bool flip = true;
	
	// Update is called once per frame
	void Awake () 
	{
		if(flip == true)
			AverageSpeed = AverageSpeed * -1;
	}
}
