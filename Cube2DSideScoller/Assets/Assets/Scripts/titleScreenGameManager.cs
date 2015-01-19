using UnityEngine;
using System.Collections;

public class titleScreenGameManager : MonoBehaviour 
{
	public bool Clicked = false;

	public void LoadNextLevel()
	{
		Application.LoadLevel("Test");
	}

}
