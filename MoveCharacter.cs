using System;
using Lean.Gui;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public LeanJoystick stick;
    public float speed;
    public float jumpForce;
    private Rigidbody rigid;
    private bool isGrounded;


    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = stick.ScaledValue.x;
        float moveVertical = stick.ScaledValue.y;

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);


        if (stick.ScaledValue.x != 0 && stick.ScaledValue.y != 0)
            transform.rotation = Quaternion.LookRotation(movement);

        rigid.velocity = new Vector3(movement.x * speed, rigid.velocity.y, movement.z * speed);
        
       
    }

    public void Jump()
    {
        if (isGrounded) 
        {
            rigid.AddForce(0, jumpForce * 10, 0);
            isGrounded = false;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }
}