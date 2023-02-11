using UnityEngine;
using UnityEngine.SceneManagement;



public class CreditsScript : MonoBehaviour {

    public void MainMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void Quit() {
        Debug.Log("I quit...");
    }
}
