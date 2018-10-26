using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class CreateCoins : MonoBehaviour
{

	public GameObject Coins;
	public GameObject Trigger;
	public UnityEvent startCoinsEvent;
	public int createMultiply = 20;


	private void Update()
	{
		CreatingCoins();
	}

	//call this in a coroutine like the timer in TimeSet
	public void CreatingCoins()
	{
		Instantiate(Coins, Trigger.transform.position, Quaternion.identity);
	}

	public void subjectCoins()
	{
		StartCoroutine(CreatingCoins());
	}

	IEnumerable CreatingCoins()
	{
		startCoinsEvent.Invoke;
		int sweetCoinsNum = createMultiply; 
		
		while 
	}
