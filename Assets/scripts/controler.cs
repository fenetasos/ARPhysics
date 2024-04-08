﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    protected Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 2f + Input.GetAxis("Horizontal") * 2f,
                                                        rigidbody.velocity.y,
                                                            joystick.Vertical * 2f + Input.GetAxis("Vertical") * 2f);
    }
}
