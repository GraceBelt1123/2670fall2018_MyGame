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
    public float SecondSpeed = 10.0f;
    public float ThirdSpeed = 10.0f;

    void Update()
    {
        Falling();
        secondFalling();
        thirdFalling();
    }

    public void Falling()
    {
        transform.Translate(Vector3.down * FallSpeed * Time.deltaTime, Space.World);
    }

    public void secondFalling()
    {
        transform.Translate(Vector3.down * SecondSpeed * Time.deltaTime, Space.World);
    }

    public void thirdFalling()
    {
        transform.Translate(Vector3.down * ThirdSpeed * Time.deltaTime, Space.World );
    }
}














































