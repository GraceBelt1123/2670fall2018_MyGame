using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondFallingCoins : MonoBehaviour
{//This is the Second Level's Speed.

    public GameObject Coins;
    public float secondSpeed = 8.0f;

    void Update()
    {
        luckyCoins();
    }

    public void luckyCoins()
    {
        transform.Translate(Vector3.down * secondSpeed * Time.deltaTime, Space.World);
    }
}
