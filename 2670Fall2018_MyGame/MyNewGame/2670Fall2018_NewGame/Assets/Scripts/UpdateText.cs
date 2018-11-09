using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{

	public ActionObject Action;
	public Text Label;
	private IntData number;

	void Start()
	{
		Label = GetComponent<Text>();
		Action.Raise += RaiseHandler;
	}

	private void RaiseHandler()
	{
		number.Value++;
		Label.text = number.ToString();
	}
}
