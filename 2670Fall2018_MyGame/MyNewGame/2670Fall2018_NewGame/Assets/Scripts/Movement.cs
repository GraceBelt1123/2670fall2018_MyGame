
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject Player;
    public float Speed = 5f;
    public bool iControl;
    public GameObject Coins;
    public float fallSpeed = 40.0f;
    public GameObject Trigger;
    

    void Update()
    {
        if (iControl == true)
        {
            float sweet = Input.GetAxis("Horizontal") * Speed;
            Player.transform.Translate(sweet * Time.deltaTime, 0, 0);
        }
    }

    
}

    

 