using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour {

	public GameObject winText;
	public GameObject loseText;
	public bool didWin;
	public int score;


	//do stuff when the timer is started
	public void StartGame()
	{
		print("started game");
		winText.SetActive(false);
		loseText.SetActive(false);
	}

	//do stuff when the timer has ended
	public void EndGame()
	{

		//if score is greater than 5, set didWin equal to true
		//if score is less than 5, set didWin equal to false

		print("ended game");
		if(didWin)
		{
			winText.SetActive(true);
		}
		
		if (!didWin)
		{
			loseText.SetActive(true);
		}

	}


}
