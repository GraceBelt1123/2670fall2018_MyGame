using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Single Variables/IntData")]
public class IntData : MonoBehaviour
{

	public int Value;

	public void UpdateValue(int i)
	{
		Value += i; 
	}
}
