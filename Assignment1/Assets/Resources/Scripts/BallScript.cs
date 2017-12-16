using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public Player1PaddleScript paddlePlayer1;
    public Player2PaddleScript paddlePlayer2;
    Vector3 paddleBallPosDiff;
    bool gameStart = false;
    public int player1Score = 0;
    public int player2Score = 0;
    public float speed;
    public GameObject obstacle;
    LevelManager levelManager = new LevelManager();

    // Use this for initialization
    void Start () {

        obstacle = GameObject.FindGameObjectWithTag("obstacle");
        moveObstacles();
        paddlePlayer1 = GameObject.FindObjectOfType<Player1PaddleScript>();

        paddleBallPosDiff = this.transform.position - paddlePlayer1.transform.position;
    }

    // Update is called once per frame
    void Update () {
        ballStart();
    }

    public void ballStart()
    {
        //paddlePlayer1 = GameObject.FindObjectOfType<Player1PaddleScript>();

       // paddleBallPosDiff = this.transform.position - paddlePlayer1.transform.position;

        //this.transform.position = paddlePlayer1.transform.position + paddleBallPosDiff;

        //on start scene, start ball movement
        //this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -1f);


        if (!gameStart) //if(gameStart==false)
        {
            this.transform.position = paddlePlayer1.transform.position + paddleBallPosDiff;
        }

        if (!gameStart && Input.GetMouseButtonDown(0))
        {
            gameStart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -1f);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string colName = collision.collider.name;

        if (gameStart && (colName == "PaddlePlayer1" || colName == "PaddlePlayer2" || colName == "TopBorder" || colName == "BottomBorder" || colName == "RightBorder1" || colName == "RightBorder2" || colName == "LeftBorder1" || colName == "LeftBorder2" || colName == "Obstacle1" || colName == "Obstacle2"))
        {
            //GetComponent<AudioSource>().Play();
            Vector2 tweak = new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(0f, 0.2f));
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }

    public void moveObstacles()
    {
        if (levelManager.GetScene() == "Level3")
        {
            obstacle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1f);
        }
    }





    /*if (!gameStart) //if(gameStart==false)
        {
            this.transform.position = paddlePlayer1.transform.position + paddleBallPosDiff;
        }

        if (!gameStart && Input.GetMouseButtonDown(0))
        {
            gameStart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -1f);
        }*/

    //paddlePlayer1 = GameObject.FindObjectOfType<Player1PaddleScript>();

    //paddleBallPosDiff = this.transform.position - paddlePlayer1.transform.position;
}
