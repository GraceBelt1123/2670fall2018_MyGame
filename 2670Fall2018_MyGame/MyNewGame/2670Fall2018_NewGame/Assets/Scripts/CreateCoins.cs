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


	private void Update()
	{
		CreatingCoins();
	}

	//call this in a coroutine like the timer in TimeSet
	public void CreatingCoins()
	{
		Instantiate(Coins, Trigger.transform.position, Quaternion.identity);
	}

}
