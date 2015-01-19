using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour 
{
	public bool IsTitleScreen = false;
	public GameObject ObjectsToDestroy;

	void Update()
	{
		if(IsTitleScreen = true && Input.touchCount == 1)
		{
			DestroyObject();
		}
	}

	public void DestroyObject()
	{
		if(IsTitleScreen = true)
		{
			Destroy(ObjectsToDestroy);
		}
		Destroy(this.gameObject);
	}
}
