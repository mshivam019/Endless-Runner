using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelCompleteScript : MonoBehaviour {
	public Text LevelCompleteText;
	private static int score;
	public Text Feedback;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		score = PickUpScript.coinCounter;
		LevelCompleteText.text = "Level Complete! Your score was " + score;
		if (score == 8){
			Feedback.text = "You made a perfect score!";
		}
		else if (score <=8 && score >=5)
		{Feedback.text = "You did pretty well.";
		}
		else if (score <=5 && score >=3)
		{Feedback.text = "You might want to play again.";
		}
		else if (score <=2 && score >=-20)
		{Feedback.text = "Your navigating needs some work!";
		}
	}
}