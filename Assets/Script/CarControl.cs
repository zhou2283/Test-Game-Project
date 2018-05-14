using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {

    float speed = 0f;
    float acc = 5f;
    float decc = 0.5f;
    float speedMax = 4f;
    float turnSpeed = 0f;
    float turnAcc = 50f;
    float turnDecc = 50f;
    float turnSpeedMax = 50f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            speed += acc * Time.deltaTime;
            if(speed > speedMax)
            {
                speed = speedMax;
            }
        }
        else
        {
            speed -= decc * Time.deltaTime;
            if (speed < 0)
            {
                speed = 0;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            turnSpeed += turnAcc * Time.deltaTime;
            if (turnSpeed > turnSpeedMax)
            {
                turnSpeed = turnSpeedMax;
            }            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            turnSpeed -= turnAcc * Time.deltaTime;
            if (turnSpeed < -turnSpeedMax)
            {
                turnSpeed = -turnSpeedMax;
            }
        }
        else
        {
            turnSpeed = 0;
        }


        transform.Rotate(new Vector3(0, turnSpeed, 0) * Time.deltaTime);
        transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime, Space.Self);

    }
}
