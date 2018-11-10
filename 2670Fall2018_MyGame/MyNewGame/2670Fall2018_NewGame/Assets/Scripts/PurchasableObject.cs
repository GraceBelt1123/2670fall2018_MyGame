using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Purchase", menuName = "Store/Purchasable")]
public class PurchasableObject : ScriptableObject
{

	public Object Item;
	public int Value;
	public bool Purpetual;
	public bool Instanciatable;

	public void CreateItem()
	{
		if (Instanciatable && Item is GameObject)
		{
			Instantiate(Item);
		}
	}

}
