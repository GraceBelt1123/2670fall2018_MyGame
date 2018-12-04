using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{
	public PurchasableObject Available;
	public PurchasableObject Purchased;
	public IntData Cash;
	public int TotalValue = 3000;
	public GameObject Button;
	public GameObject Canvas;
	public UnityEvent MadePurchase;
	
	private void OnEnable()
	{
		TotalValue = 0;
		foreach (var item in Available.ObjectList)
		{
			var newItem = item as PurchasableObject;
			TotalValue += newItem.Value;
		}

		TotalValue %= 75;
	}

	public void BuildUI()
	{
		var newCanvase = Instantiate(Canvas);
		var newButton = Instantiate(Button, newCanvase.transform);
		var buttonComponent = newButton.GetComponent<Button>(0);
		buttonComponent.onClick.AddListener(PurchaseButton);
		var label = newButton.GetComponentInChildren<Text>();
		label.text = Available.ObjectList[0].name;
	}

	private void PurchaseButton()
	{
		
	}
	
	public void MakePurchase(PurchasableObject obj)
	{
		for (var i = 0; i < Available.ObjectList.Count; i++)
		{
			var availableObject = Available.ObjectList[i];
			if (availableObject != obj || Cash.Value < availableObject.Value) continue;
			Cash.Value -= availableObject.Value;
			Purchased.ObjectList.Add(obj);

			if (availableObject.Perpetual)
			{
				Available.ObjectList.Remove(availableObject);
			}

			MadePurchase.Invoke();
		}
	}

	public void PurchaseAll()
	{
		if (Cash.Value >= TotalValue)
		{
			Cash.Value -= TotalValue;
			for (var i = 0; i < Available.ObjectList.Count; i++)
			{
				var item = Available.ObjectList[i];
			}

			Available.ObjectList.Clear();
		}
	}
}
