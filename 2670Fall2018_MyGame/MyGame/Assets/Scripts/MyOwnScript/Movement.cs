using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public GameObject RedPlayer;
    public float Speed = 5f;
    public bool iControl;

    void Update()
    {
        if (iControl == true)
        {
            float sweet = Input.GetAxis("Horizontal") * Speed;
            RedPlayer.transform.Translate(sweet*Time.deltaTime, 0, 0);
        }
    }
}

