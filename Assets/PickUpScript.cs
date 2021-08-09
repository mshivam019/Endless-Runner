using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickUpScript : MonoBehaviour {
	public static int coinCounter;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		coinCounter = 0;
	}
	// Update is called once per frame
	void Update () {
	}
	void OnControllerColliderHit (ControllerColliderHit hit){
		if (hit.gameObject.CompareTag ("addPoint")) {
			Destroy (hit.gameObject);
			coinCounter++;
			scoreText.text = "Score: " + coinCounter.ToString ();
		}
		else if (hit.gameObject.CompareTag ("losePoint")) {
			Destroy (hit.gameObject);
			coinCounter--;
			scoreText.text = "Score: " + coinCounter.ToString ();
		}
		else if (hit.gameObject.CompareTag ("levelOneEnd")) {
			SceneManager.LoadScene("Level Complete", LoadSceneMode.Single);
		}
	}
}