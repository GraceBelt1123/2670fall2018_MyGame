using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

[CreateAssetMenu(menuName = "Single Variables/IntData")]
public class IntData : ScriptableObject
{
	public int Value;

	public void UpdateValue(int i)
	{
		Value += i; 
	}

	public void UpdateValue(IntData data)
	{
		Value += data.Value;
	}
}
