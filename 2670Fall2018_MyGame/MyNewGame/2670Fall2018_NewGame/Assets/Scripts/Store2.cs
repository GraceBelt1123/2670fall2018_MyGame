using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Store2", menuName = "Store2/StoreFront")]
public class Store2 : ScriptableObject
{

	public Object Item;
	public List<Object> Purchased;
	public int ItemValue;
	public FinalScore Cash;
	
	
	public void Purchase()
	{
		if (Cash.Money >= ItemValue)
		{
			Purchased.Add(Item);
			Cash.Money -= ItemValue;
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
