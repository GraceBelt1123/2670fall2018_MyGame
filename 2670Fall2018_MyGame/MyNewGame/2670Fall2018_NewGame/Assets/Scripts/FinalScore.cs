using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class FinalScore : ScriptableObject
{
    public int Money;

    public void RestartFinalScore()
    {
        Money = 0;
    }
}
