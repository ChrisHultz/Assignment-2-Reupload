using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateColor : MonoBehaviour {
    public GameObject player;
    static int ColorOfBall;
    
    void FixedUpdate() {
        ColorOfBall = Settings.ColorSelect;
        //Color Pass
        if (ColorOfBall == 1) {
            player.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ColorOfBall == 2) {
            player.GetComponent<Renderer>().material.color = Color.white;
        }
        else if (ColorOfBall == 3) {
            player.GetComponent<Renderer>().material.color = Color.blue;
        }
        else {
            player.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}