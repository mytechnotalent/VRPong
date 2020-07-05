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

public class LeftHit : MonoBehaviour
{
    public RightPaddle RightScore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Check if ball has touched left goal as when
    // a specific goal has been breached the opposing
    // player gets a point and we need to reset the
    // back back to the middle of the game with a
    // small pause and move in a random direction
    private void OnTriggerEnter(Collider other)
    {
        RightScore.score++;

        // When either goal is collided with we
        // call the ball to origin wherever the
        // ball is located
        GameObject.Find("Ball").GetComponent<Ball>().ReturnToOrigin();
    }
}
