using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackdistance : MonoBehaviour {

    public float distanceTravelled = 0;
    Vector3 lastPosition;

    // Use this for initialization
    void Start () {
        lastPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
    }
}
