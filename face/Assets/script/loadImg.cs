using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadImg : MonoBehaviour {

    private GameObject eye;
    private GameObject m_Image;
    public Sprite eye1;

    // Use this for initialization
    void Start () {
        eye = GameObject.Find("/Canvas/eye");
    }
	
	// Update is called once per frame
	void Update () {
        eye.GetComponent<Image>().sprite = eye1;
    }
}
