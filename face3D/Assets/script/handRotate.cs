using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handRotate : MonoBehaviour {

    private int speed;
    public GameObject leftHand;

    // Use this for initialization
    void Start()
    {
        speed = -10;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.rotation.z);
        if (transform.rotation.z > 0)
            speed = -10;
        else if (transform.rotation.z < -0.1)
            speed = 10;
        transform.Rotate(0, 0, Time.deltaTime * speed);
        leftHand.transform.Rotate(0, 0, Time.deltaTime * speed * -1);
    }
}
