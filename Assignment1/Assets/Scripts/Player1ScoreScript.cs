using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1ScoreScript : MonoBehaviour {

    BallScript ballScript = new BallScript();

    public Player1PaddleScript paddlePlayer1;
    Vector3 paddleBallPosDiff;

    public GameObject ball;

    public int maxScore;
    int player1Score;

    bool gameStart = false;

    private Vector3 initialPosition;

    public float speed;

    LevelManager levelManager = new LevelManager();

    // Use this for initialization
    void Start () {

        Vector2 zero = new Vector2(0, 0);
        initialPosition = zero;
        print(zero);
        ball = GameObject.FindGameObjectWithTag("ball");
    }
	
	// Update is called once per frame
	void Update () {
        if(player1Score == 5)
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

        player1Score++;
        print("Player 1 Score: " + player1Score);

        ball.transform.position = initialPosition;
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -1f);


    }
}
