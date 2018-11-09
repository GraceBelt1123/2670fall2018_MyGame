using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PerCounter : MonoBehaviour
{
    public UnityEvent OnCount;
    public FloatData Seconds;

    IEnumerable Start()
    {
        while (true)
        {
            OnCount.Invoke();
            yield return new WaitForSeconds(Seconds.Value);
        }
    }
}
