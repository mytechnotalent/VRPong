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

public class GameController : MonoBehaviour
{
    public LeftPaddle leftHandPlayer;
    public RightPaddle rightHandPlayer;

    public TextMesh infoText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Every frame update score and since it
        // is an int we need to cast to a string
        infoText.text
            = leftHandPlayer.score.ToString()
            + "                                    "
            + rightHandPlayer.score.ToString();
    }
}
