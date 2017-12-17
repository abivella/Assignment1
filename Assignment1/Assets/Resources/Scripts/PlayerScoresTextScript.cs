using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoresTextScript : MonoBehaviour {

    public Text player1Score;
    public Text player2Score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player1Score.text = "Player 1: " + Player1ScoreScript.player1Score;
        player2Score.text = "Player 2: " + Player2ScoreScript.player2Score;
	}
}
