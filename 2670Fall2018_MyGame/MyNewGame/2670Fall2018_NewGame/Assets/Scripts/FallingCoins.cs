using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCoins : MonoBehaviour
{
    //This is to make coins that is starting to fall from the gameObject when is pressed play, 
    //when the coins hit the ground, then will return back to the gameObject.
    //It will be repeated the same thing over and over again. 
    
    public GameObject Coins;
    public float FallSpeed = 10.0f;

    void Update()
    {
        Falling();
    }

    public void Falling()
    {
        transform.Translate(Vector3.down * FallSpeed * Time.deltaTime, Space.World);
    }
}
