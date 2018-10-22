
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject Player;
    public float Speed = 5f;
    public bool iControl;

    void Update()
    {
        if (iControl == true)
        {
            float sweet = Input.GetAxis("Horizontal") * Speed;
            Player.transform.Translate(sweet * Time.deltaTime, 0, 0);
        }
    }
}

    

 