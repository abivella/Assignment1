using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

    //private Vector2 startPosition;
    float speed = 4f;

    public Transform obstacle; 
    public Transform destinationTrans;

    Vector3 start;
    Vector3 destination;
    Vector3 nextDestination;

	// Use this for initialization
	void Start () {
        start = obstacle.position;
        destination = destinationTrans.position;

        nextDestination = destination;
    }
	
	// Update is called once per frame
	void Update () {
        obstacle.position = Vector3.MoveTowards(obstacle.position, nextDestination, speed * Time.deltaTime);
        if (Vector3.Distance(obstacle.position, nextDestination) <=0.1)
        {
            if(nextDestination == destination)
            {
                nextDestination = start;
            }
            else if(nextDestination == start)
            {
                nextDestination = destination;
            }
        }
	}
}
