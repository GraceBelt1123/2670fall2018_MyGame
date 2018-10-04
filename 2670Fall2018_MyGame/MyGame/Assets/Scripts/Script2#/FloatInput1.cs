using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "FloatInput")]
public class FloatInput1 : MonoBehaviour
{

    public string InputType;

    public override float Value
    {
        get { return Input.GetAxis(InputType) * value; }
    }
}
