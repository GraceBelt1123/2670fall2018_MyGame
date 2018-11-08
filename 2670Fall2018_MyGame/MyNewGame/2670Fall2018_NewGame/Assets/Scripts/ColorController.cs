using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ColorController : ScriptableObject
{

	public List<NameID> ID;
	public List<ColorData> ObjColor;
	public GameObject RingPrefab;
	public GameObject DotPrefab;
	private int i = 0;

	private void OnEnable()
	{
		i = 0;
	}

	public void Create()
	{
		Build(RingPrefab);
		Build(DotPrefab);

		if (i < ObjColor.Count - 1)
		{
			i++;
		}
		else
		{
			{
				i = 0;
			}
		}
	}

	public void Build(GameObject go)
	{
		var newGo = Instantiate(go)
		newGo.GetComponent<ObjectID>().ID = ID[i];
		newGo.GetComponent<SpriteRenderer>().color = ObjColor[i].value;
	}

}
