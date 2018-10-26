using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class TimeSet : MonoBehaviour
{
	public int startingNumber = 30;

	public Text text;

	public UnityEvent startTimerEvent;
	public UnityEvent endTimerEvent;
	
	//This is countdown in 30 seconds when it is pressed the button "Play".

	public void StartCountDown()
	{
		StartCoroutine(CountDown());
	}

	IEnumerator CountDown()
	{
		startTimerEvent.Invoke();
		int tempStartingNum = startingNumber;

		while(tempStartingNum > 0)
		{
			tempStartingNum--;
			text.text = tempStartingNum.ToString();
			yield return new WaitForSeconds(1);	
		}

		endTimerEvent.Invoke();
		text.text = "Restart";
	}
}
