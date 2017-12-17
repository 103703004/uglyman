using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Random_move : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 temp = new Vector3(Random.Range(0.6f, 1000.6f), Random.Range(0.6f, 1000.6f), 0);
        transform.position = temp;
	}

    private static float Range(float p1, float p2)
    {
        throw new System.NotImplementedException();
    }
}
