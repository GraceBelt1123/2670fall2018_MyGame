using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{

    public FloatData jumpSpeed;
    public FloatData gravity;

    private Vector3 moveDirection;
    private CharacterController controller;
    private Vector3 rotDirection;

    public FloatData MoveX, MoveY, MoveZ;
    public FloatData RotX, RotY, RotZ;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.IsGrounded)
        {
            moveDirection.Set(MoveX.Value, MoveY.Value, Movez.Value);
            rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
            transform.Rotate(rotDirection);

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed.Value;
        }

        moveDirection.y -= gravity.Value * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }


}
