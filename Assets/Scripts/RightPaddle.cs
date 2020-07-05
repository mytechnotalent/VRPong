//
// VRPong
// ******
// 
// Created by Kevin Thomas 01/04/20.
// Modified by Kevin Thomas 01/06/20.
//
// Apache License, Version 2.0
// 
// VRPong is a Oculus Rift and Oculus Quest game that is a 
// classic Pong clone where have two paddles to which
// your left controller handles the left paddle and the
// right controller to hanldle the right paddle.  Tons
// of retro fun in this game!
//


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RightPaddle : MonoBehaviour
{
    public int score;
    public float speed = 5;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Look at current game object and call 'GetComponent'
        // off of object of type 'Rigidbody' and store in
        // rb variable as it is private as we do not want
        // other scripts to have access to its properties
        // or functionality
        rb = GetComponent<Rigidbody>();
    }

    // Update is called frame rate independently
    void FixedUpdate()
    {
        // If we press left we are moving the left paddle
        // on the x axis and we add force to our object
        // with Vector3 and to move left we move negative
        // 'speed' meters per second on the x axis and the
        // reverse for right
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            rb.MovePosition
            (
                transform.position + Vector3.right * -speed * Time.deltaTime
            );
        }
        else if (OVRInput.Get(OVRInput.Button.One))
        {
            rb.MovePosition
            (
                transform.position + Vector3.right * speed * Time.deltaTime
            );
        }
    }
}
