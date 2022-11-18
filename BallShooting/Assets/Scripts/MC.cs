using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;

public class MC : MonoBehaviour
{
    public Joystick joystick;
    float moveSpeed = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (joystick.Horizontal != 0 && joystick.Vertical != 0)
        {
            float moveHorizontal = joystick.Horizontal * moveSpeed;
            float moveVertical = joystick.Vertical * moveSpeed;
            float angleRotate = Mathf.Atan2(joystick.Vertical, joystick.Horizontal) * Mathf.Rad2Deg;

            //Debug.Log(angleRotate);
            transform.position += new Vector3(moveHorizontal, moveVertical, 0);
            transform.eulerAngles = new Vector3(0, 0, angleRotate);
        }
    }
}
