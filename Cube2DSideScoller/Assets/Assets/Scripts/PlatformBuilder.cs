using UnityEngine;
using System.Collections;

public class PlatformBuilder : MonoBehaviour {

	public GameObject Platform;
	public GameObject[] PlatFormPoints;
	GameObject currentPoint;
	int index;
	public float delay = 1.0f;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating("PlatformBuild", delay, delay);
	}
	
	// Update is called once per frame
	void PlatformBuild () 
	{
		index = Random.Range (0, PlatFormPoints.Length);
		currentPoint = PlatFormPoints[index];
		Instantiate(Platform, PlatFormPoints[index].transform.position , Quaternion.identity);
	}
}
