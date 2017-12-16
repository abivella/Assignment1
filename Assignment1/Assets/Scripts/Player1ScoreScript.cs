using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1ScoreScript : MonoBehaviour {

    BallScript ballScript = new BallScript();
    public Player1PaddleScript paddlePlayer1;
    public GameObject ball;
    static int player1Score;
    int goal;
    public int speed;
    private Vector3 initialPosition;

    LevelManager levelManager = new LevelManager();

    // Use this for initialization
    void Start () {

        Vector2 zero = new Vector2(0, 0);
        initialPosition = zero;
        //print(zero);
        ball = GameObject.FindGameObjectWithTag("ball");
    }
	
	// Update is called once per frame
	void Update () {
        if(goal == 3)
        {
            levelManager.LoadNextScene();
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        goal++;
        if(levelManager.GetScene() == "Level1")
        {
            player1Score++;
        }
        else if(levelManager.GetScene() == "Level2")
        {
            player1Score += 2;
        }
        else if(levelManager.GetScene() == "Level3")
        {
            player1Score += 3;
        }
       
        print("Player 1 Score: " + player1Score);

        ball.transform.position = initialPosition;
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -1f);


    }
}
