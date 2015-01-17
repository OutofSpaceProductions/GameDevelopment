using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public float AverageSpeed = 1.0f;
	public bool flip = true;
	public Text scoreText;
	private float floatScore;
	private int Score;
	
	// Update is called once per frame
	void Awake () 
	{
		if(flip == true)
			AverageSpeed = AverageSpeed * -1;
	}
	void Update()
	{
		AddScore(1);
	}
	void AddScore(int PointValue)
	{
		floatScore += Time.deltaTime;
		Score = (int)floatScore;
		scoreText.text = ("Score:" + Score);
	}
}
