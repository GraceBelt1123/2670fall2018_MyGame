using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatBool : FloatInput {

	public override float Value
	{
		get
		{
			if (Input.GetButton(InputType))
			{
				return Value;
			}
			else
			{
				return 0;
			}
		}
	}
}
