using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject Player;
    public float Speed = 5f;
    public bool iControl;
    public float Jump = 10.0f;

    void Update()
    {
        if (iControl == true)
        {
            float sweet = Input.GetAxis("Horizontal") * Speed;
            Player.transform.Translate(sweet * Time.deltaTime, 0, 0);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * Jump);
    }
}

    

