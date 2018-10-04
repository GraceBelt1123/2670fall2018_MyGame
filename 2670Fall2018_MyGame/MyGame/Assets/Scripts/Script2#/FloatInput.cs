using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "FloatInput")]
public class FloatInput : MonoBehaviour
{

	public string InputType;

	public virtual float Value
	{
		get { return Input.GetAxis(InputType) * Value; }
	}
}
