using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryCoins : MonoBehaviour {
    
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        //create a new coin in the create coins script
    }
}
