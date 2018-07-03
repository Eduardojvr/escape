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
        if(Input.GetButtonDown("frente")){
            x += 300;
            ave.AddForce(new Vector2(x, 0));
            x = 0;
        }
        if (Input.GetButtonDown("tras")){
            x -= 300;
            ave.AddForce(new Vector2(x, 0));
            x = 0;
        }
        if(Input.GetButtonDown("cima")){
            y += 300;
            ave.AddForce(new Vector2(0, y));
            y = 0;
        }
        if (Input.GetButtonDown("baixo")){
            y -= 300;
            ave.AddForce(new Vector2(0, y));
            y = 0;
        }
	}
}
