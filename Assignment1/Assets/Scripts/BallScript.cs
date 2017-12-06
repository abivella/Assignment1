using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public Player1PaddleScript paddlePlayer1;
    public Player2PaddleScript paddlePlayer2;
    Vector3 paddleBallPosDiff;
    bool gameStart = false;


    // Use this for initialization
    void Start () {

        paddlePlayer1 = GameObject.FindObjectOfType<Player1PaddleScript>();

        paddleBallPosDiff = this.transform.position - paddlePlayer1.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        if (!gameStart) //if(gameStart==false)
        {
            this.transform.position = paddlePlayer1.transform.position + paddleBallPosDiff;
        }

        if (!gameStart && Input.GetMouseButtonDown(0))
        {
            gameStart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string colName = collision.collider.name;

        if (gameStart && (colName == "PaddlePlayer1" || colName == "PaddlePlayer2" || colName == "TopBorder" || colName == "BottomBorder" || colName == "RightBorder1" || colName == "RightBorder2" || colName == "LeftBorder1" || colName == "LeftBorder2"))
        //if (gameStart && collision.collider.tag != "Breakable")
        {
            //GetComponent<AudioSource>().Play();
            Vector2 tweak = new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(0f, 0.2f));
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }

    }
}
