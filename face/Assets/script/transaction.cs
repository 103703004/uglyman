using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transaction : MonoBehaviour
{
   
    public float speed = 0.001f;//移動速度
 

    // Use this for initialization
    void Start()
    {
        this.transform.position = new Vector3(0, 100, 0);
    }

    // Update is called once per frame
    void Update()
    {
       
        this.transform.position+=new Vector3(speed*Time.deltaTime,0,0);
    }
}
