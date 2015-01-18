using UnityEngine;
using System.Collections;

public class PlatformBuilder : MonoBehaviour {

	public GameObject ShortPlatform;
	public GameObject[] PlatFormPoints;
	GameObject currentPoint;
	int index;
	public float delay = 1.0f;

	void Start () 
	{
		InvokeRepeating("ShortPlatformBuild", delay, delay);
	}

		void ShortPlatformBuild () 
	{
		index = Random.Range (0, PlatFormPoints.Length);
		currentPoint = PlatFormPoints[index];
		Instantiate(ShortPlatform, PlatFormPoints[2].transform.position , Quaternion.identity);
	}
}
