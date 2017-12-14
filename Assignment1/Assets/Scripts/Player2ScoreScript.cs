using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2ScoreScript : MonoBehaviour {

    BallScript BallScript = new BallScript();
    public int maxScore;
    int player2Score;
    public GameObject ball;
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
        if (player2Score == 5)
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
        player2Score++;
        print("Player 2 Score: " + player2Score);

        ball.transform.position = initialPosition;
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -1f);

    }
}
