using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up"))
        {
            //print("up");
            this.GetComponent<Rigidbody2D>().AddForce(this.transform.right * 10);
        }

        else if (Input.GetKey("down"))
        {
            //print("down");
            this.GetComponent<Rigidbody2D>().AddForce(this.transform.right * (10 * -1));
        }
    }
}
