﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text score;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		score.text =GameManager.score.ToString ();
	}
}
