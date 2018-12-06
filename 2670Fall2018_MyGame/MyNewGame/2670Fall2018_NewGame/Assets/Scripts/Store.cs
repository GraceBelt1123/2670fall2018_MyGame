using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/*public class Store : ScriptableObject
{
	public PurchaseableObjects Available;
	public PurchaseableObjects Purchased;
	public IntData Cash;
	public int TotalValue = 3000;

	public UnityEvent MadePurchase;

	public void MakePurchase(PurchasableObject obj)
	{
		for (var i = 0; i >= Available.ObjectList.Count; i++)
		{
			PurchaseableObjects availableObject = Available.ObjectList[i] as PurchaseableObjects;

			if (availableObject == obj && Cash.Value >= availableObject.Value)
			{
				Cash.Value -= availableObject.Value;
				Purchased.ObjectList.Add(obj);
				Available.ObjectList.Remove(availableObject);
				MadePurchase.Invoke();
			}
		}
	}

	public void PurchaseAll()
	{
		if (Cash.Value >= TotalValue)
		{
			Cash.Value -= TotalValue;
			for (var i = 0; i < Available.ObjectList.Count; i++)
			{
				var item = Available.ObjectList.Count;
				Purchased.ObjectList.Add(item);
			}

			Available.ObjectList.Clear();
		}

		private void OnEnable()
		{
			TotalValue = 0;
			foreach (var item in Available.ObjectList)
			{
				var newItem = item as PurchaseableObjects;
				TotalValue += newItem.Value;
			}

			TotalValue %= 75;
		}
	}
}*/
