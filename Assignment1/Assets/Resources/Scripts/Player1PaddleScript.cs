using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //print(Input.mousePosition.x);

        float mousePosInUnits = (Input.mousePosition.y / Screen.width * 16) - 8;

        Vector3 newPaddlePos = new Vector3(this.transform.position.x, mousePosInUnits,
                                 this.transform.position.z);
        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -7.5f, 7.5f);


        this.transform.position = newPaddlePos;
    }
}
