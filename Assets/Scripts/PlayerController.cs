using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	private float speed = Settings.PlayerSpeed;
	public TextMeshProUGUI countText;
	public GameObject winTextObject;
    public GameObject player;
    private float movementX;
    private float movementY;
    float size = Settings.UpdateSize;
	private Rigidbody rb;
	private int count;
    
    

	void Start () {
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
        winTextObject.SetActive(false);
    }

	void FixedUpdate () {
		Vector3 movement = new Vector3 (movementX, 0.0f, movementY);
		rb.AddForce (movement * speed);
        player.transform.localScale = new Vector3(size,size,size);
        player.transform.localPosition = new Vector3(player.transform.localPosition.x, 0.5f * size, player.transform.localPosition.z);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

        void OnMove(InputValue value) {
        	Vector2 v = value.Get<Vector2>();
        	movementX = v.x;
        	movementY = v.y;
        }

        void SetCountText() {
		countText.text = "Count: " + count.ToString();

		if (count >= 12) {
            winTextObject.SetActive(true);
			Invoke("NextScene", 5.0f);
			
		}
	}

	public void NextScene() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}