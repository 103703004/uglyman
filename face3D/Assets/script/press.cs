using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class press : MonoBehaviour {


    public GameObject canvas;
    public Text text;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        Debug.Log(Input.mousePosition);
        text.text = Input.mousePosition.ToString();
        canvas.SetActive(true);
    }

}
