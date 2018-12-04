using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "SingleVars/IntData")]
public class IntData : ScriptableObject
{
	public int Value;

	public void UpdateValue(int i)
	{
		Value += i; 
	}
}
