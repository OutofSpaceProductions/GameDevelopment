using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public float AverageSpeed = 1.0f;
	public bool flip = true;
	public Text scoreText;
	private float floatScore;
	private int Score;
	private int health = 100;
	public int MinorDamage = 1;  
	public Slider healthSlider;
	public Slider powerUpSlider;
	public int KillEnemyValue = 5;
	private int PowerUpScore = 0;
	bool powerUpAvaible = false;


	// Update is called once per frame
	void Awake () 
	{
		if(flip == true)
			AverageSpeed = AverageSpeed * -1;
	}
	void Update()
	{
		AddScore(1);
		//if(powerUpAvaible == true && Input.
		if(health == 0)
		{
			Debug.Log("Dead");
			Dead();
		}
	}
	public void AddScore(int PointValue)
	{
		floatScore += Time.deltaTime;
		Score = (int)floatScore;
		scoreText.text = ("Score:" + Score);
	}
	public void DestroyedEnemy(int PointValue)
	{
		AddScore(KillEnemyValue);
		PowerUpScore += 1;
		powerUpSlider.value = PowerUpScore;
		if(powerUpSlider.value == powerUpSlider.maxValue)
		{
			powerUpAvaible = true;
			powerUpSlider.maxValue = powerUpSlider.maxValue * 2;
			powerUpSlider.value = 0;
		}
	}
	public void Health(int Damage)
	{
		health -= Damage;
		healthSlider.value = health;

	}
	public void Dead()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}
