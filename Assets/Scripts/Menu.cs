using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public void StartGame() {
        SceneManager.LoadScene("Minigame");
    }

    public void LoadSettings() {
        SceneManager.LoadScene("Settings");
    }
}
