using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTextScript : MonoBehaviour {

    public Text winner;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Player1ScoreScript.player1Score > Player2ScoreScript.player2Score)
        {
            winner.text = "PLAYER 1 IS THE WINNER";
        }
        else if (Player1ScoreScript.player1Score < Player2ScoreScript.player2Score)
        {
            winner.text = "PLAYER 2 IS THE WINNER";
        }
    }
}
