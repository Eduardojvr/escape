using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour {

    public Rigidbody2D ave;
    public float y = 0;
    public float x = -8;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Vertical"))	{
            y += 100;
            ave.AddForce(new Vector2(0, y));
        }
	}
}
