using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing.Extension;

[CreateAssetMenu(fileName = "Objects", menuName = "Store/Objects")]
public class PurchaseableObjects : ScriptableObject
{

	public List<PurchasableObject> ObjectList;

	void Start()
	{
		for (var index = 0; index < Purchased.ObjectList.Count; index++)
		{
			var obj = Purchased.ObjectList[i];
			obj.CreateItem();
			if (!obj.Perpetual)
			{
				Purchased.ObjectList.Remove(obj);
			}
		}
	}
}
