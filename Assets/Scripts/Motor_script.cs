using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor_script : MonoBehaviour
{
    public WheelJoint2D backTire;
    public WheelJoint2D frontTire;
    public Rigidbody2D bikeRigidbody;

    public float move = 0f;
    public float rotation = 0f;

    public float speed = 1500f;
    public float rotationSpeed = 500f;

    // Update is called once per frame
    void Update()
    {
        //vertical means up and down buttons
        //horizontal means left and right buttons
        move = -Input.GetAxisRaw("Vertical") * speed;
        rotation = -Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        if (move == 0f)
        {
            backTire.useMotor = false;
            frontTire.useMotor = false;
        }
        else
        {
            backTire.useMotor = true;
            frontTire.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = move, maxMotorTorque = 10000 };
            backTire.motor = motor;
            frontTire.motor = motor;
        }

        bikeRigidbody.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
        //frontTire.AddTorque(move * speed * Time.fixedDeltaTime);
        //backTire.AddTorque(move * speed * Time.fixedDeltaTime);
        //bikeRigidbody.AddTorque(move * bikeTorque * Time.fixedDeltaTime);
    }
}
