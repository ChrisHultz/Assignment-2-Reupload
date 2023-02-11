using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {
    public Text pauseText;
    private bool isPaused = false;

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                pauseText.enabled = false;
                ResumeGame();
            }
            else {
                pauseText.enabled = true;
                Pause();
            }
        }
        if (!isPaused) {
            pauseText.text = "Game is paused";
        }
    }

    void Pause() {
        Time.timeScale = 0;
        isPaused = true;
        pauseText.text = "Game is paused";
    }
    public void ResumeGame() {
        Time.timeScale = 1;
        isPaused = false;
    }

}