using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdataText : MonoBehaviour
{

	public IntData Data;
	private Text label;
	
	void Start ()
	{
		label = GetComponent<Text>();
		OnUpdata();
	}

	public void OnUpdata()
	{
		label.text = Data.Value.ToString("C0");
	}
}
