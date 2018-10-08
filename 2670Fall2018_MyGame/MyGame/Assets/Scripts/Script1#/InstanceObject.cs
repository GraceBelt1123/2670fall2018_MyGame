using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArtisonDream.Experimental
{
[CreateAssetMenu]
public class InstanceObject : ScriptableObject
{

    public void Call(GameObject instance)
    {
        Instantiate(instance);
    }
}
}