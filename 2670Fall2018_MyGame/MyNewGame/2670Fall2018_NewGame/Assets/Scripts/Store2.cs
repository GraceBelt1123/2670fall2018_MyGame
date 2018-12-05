using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Store2 : ScriptableObject
{

	public object Item;
	public List<object> Purchased;
	public int ItemValue;
	public IntData Cash;
	
	public void Purchase()
	{
		if (Cash >= ItemValue)
		{
			Purchased.Add(Item);
			Cash.Value -= ItemValue;
		}
	}

	public void AddObjectToGame()
	{
		if (Purchased.Count > 0)
		{
			Instantiate(Purchased[0]);
			Purchased.RemoveAt(0);
		}
	}
}
