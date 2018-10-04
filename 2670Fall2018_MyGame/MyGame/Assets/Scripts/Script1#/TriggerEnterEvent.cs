using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
    }
}
