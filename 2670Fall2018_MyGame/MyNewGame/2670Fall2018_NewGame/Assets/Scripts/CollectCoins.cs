using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.Build;
using UnityEngine;

public class CollectCoins : MonoBehaviour {
 //This to make the Player collect coins, related to the score. 

    public float Money;
    
    public void OnTriggerEnter(Collider other)
    {
        print("Store");//It worked.
    }

    public void CoinCollected()
    {
    }
}
