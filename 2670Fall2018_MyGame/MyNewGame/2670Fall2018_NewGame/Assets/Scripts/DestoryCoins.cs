using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryCoins : MonoBehaviour {
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            print("Destory");
            Destroy(other.gameObject);
        }
    }
}
