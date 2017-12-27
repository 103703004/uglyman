using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {

    private float speed;
    public GameObject leftLeg;

	// Use this for initialization
	void Start () {
        speed = -0.05f;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(transform.position.y);
        //Debug.Log(speed);
        if (transform.position.y > -8)
            speed = -0.05f;
        else if (transform.position.y < -9)
            speed = 0.05f;
        transform.position += new Vector3(0, speed, 0);
        leftLeg.transform.position += new Vector3(0, -speed, 0);
    }
}
