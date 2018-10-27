using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCoins : MonoBehaviour
{ //This is the First Level's Speed. 
    
    public GameObject Coins;
    public float FallSpeed = 5.0f;

    void Update()
    {
        Falling();
    }

    public void Falling()
    {
        transform.Translate(Vector3.down * FallSpeed * Time.deltaTime, Space.World);
    }
}














































