using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{ //This is the Third Level's Speed. 

	public GameObject Coins;
	public float LuckSpeed = 15.0f;

	void Update()
	{
		JackFalling();
	}

	void JackFalling()
	{
		transform.Translate(Vector3.down * LuckSpeed * Time.deltaTime, Space.World);
	}
}
