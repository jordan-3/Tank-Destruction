﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    protected Joystick joystick;
    protected Joybutton joybutton;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();

    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Vertical * 10f + Input.GetAxis("Vertical") * 10f,
                                             rigidbody.velocity.y,
                                             -joystick.Horizontal * 10f - Input.GetAxis("Horizontal") * 10f);
    }
}
