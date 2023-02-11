using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {
    public void BackToMenu() {
        SceneManager.LoadScene("Menu");
    }

    public GameObject Player;
    public Dropdown ballSize;
    public Dropdown BallColor;
    public Slider speedSlider; //slider
    public Text sliderText; // slider
    public Text ColorName;
    private float size = 1.0f;
    public int pass;
    public static int ColorSelect = 4;
    public static float UpdateSize = 1.0f;
    public static float PlayerSpeed = 20;
    
    public void changeBallSize() {
        switch(ballSize.value) {
            default:
                size = 1.0f;
                UpdateSize = size;
                break;
            case 1:
                size = 1.0f;
                UpdateSize = size;
                break;
            case 2:
                size = 2.0f;
                UpdateSize = size;
                break;
            case 3:
                size = 3.0f;
                UpdateSize = size;
                break;
        }
        Player.transform.localScale = new Vector3(UpdateSize,UpdateSize,UpdateSize);
        Player.transform.localPosition = new Vector3(Player.transform.localPosition.x, 0.5f * UpdateSize, Player.transform.localPosition.z);
    }

    public void FixedUpdate() {
        if (ColorSelect == 1) {
            Player.GetComponent<Renderer>().material.color = Color.red;
            ColorName.text = BallColor.options[1].text;
        }
        else if (ColorSelect == 2) {
            Player.GetComponent<Renderer>().material.color = Color.white;
            ColorName.text = BallColor.options[2].text;
        }
        else if (ColorSelect == 3) {
            Player.GetComponent<Renderer>().material.color = Color.blue;
            ColorName.text = BallColor.options[3].text;
        }
        else {
            Player.GetComponent<Renderer>().material.color = Color.black;
            ColorName.text = BallColor.options[0].text;
        }
        Player.transform.localScale = new Vector3(UpdateSize,UpdateSize,UpdateSize);
        Player.transform.localPosition = new Vector3(Player.transform.localPosition.x, 0.5f * UpdateSize, Player.transform.localPosition.z);
    }

    public void ChooseColor() {
        switch (BallColor.value) {
            case 1:
                pass = 1;
                ColorSelect = pass;
                ColorName.text = BallColor.options[1].text;
                Player.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                pass = 2;
                ColorSelect = pass;
                ColorName.text = BallColor.options[2].text;
                Player.GetComponent<Renderer>().material.color = Color.white;

                break;
            case 3:
                pass = 3;
                ColorSelect = pass;
                ColorName.text = BallColor.options[3].text;
                Player.GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                pass = 4;
                ColorSelect = pass;
                ColorName.text = BallColor.options[0].text;
                Player.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }

    public void sliderNumber() {
        sliderText.text = speedSlider.value.ToString();
        PlayerSpeed = speedSlider.value;
    }
}