using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2ScoreScript : MonoBehaviour {

    BallScript BallScript = new BallScript();
    static int player2Score;
    public GameObject ball;
    private Vector3 initialPosition;
    public int speed;
    int goal;

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
        goal++;
        if (levelManager.GetScene() == "Level1")
        {
            player2Score++;
        }
        else if (levelManager.GetScene() == "Level2")
        {
            player2Score += 2;
        }
        else if (levelManager.GetScene() == "Level3")
        {
            player2Score += 3;
        }

        player2Score++;
        print("Player 2 Score: " + player2Score);

        ball.transform.position = initialPosition;
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -1f);

    }
}
