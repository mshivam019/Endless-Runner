﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}
	public void Level2Button (string LevelName)
	{
		SceneManager.LoadScene("Level 2", LoadSceneMode.Single);
	}
}
