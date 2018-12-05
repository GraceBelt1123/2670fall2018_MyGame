﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Purchase", menuName = "Store/Purchasable")]
public class  PurchasableObject: ScriptableObject
{

	public Object Item;
	public int UsageCount = 3;
	public int Value;
	public bool Perpetual;
	public bool Instanciatable;
	public PurchaseableObjects UpgradeFrom;

	public void CreateItem()
	{
		for (int i = 0; i < UsageCount; i++)
		{
			if (Instanciatable && Item is GameObject)
			{
				Instanciatable(Item);
			}
		}
	}
	
	public void Used()
	{
		UsageCount--; 
	}
}
