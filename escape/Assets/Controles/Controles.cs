using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour {

    public Rigidbody2D ave;
    public float y = 0;
    public float x = -8;
    public Transform colisor;
    public int posx;
    public Rigidbody2D meteor;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(colisor.position.y < -6){
            posx = UnityEngine.Random.Range(-9, 9);
            colisor.position = new Vector3(posx, 5.7f, colisor.position.z);
        }
        if(meteor.gravityScale > 1){
            meteor.gravityScale = 0;
        }

        if(Input.GetButtonDown("frente")){
            x += 150;
            ave.AddForce(new Vector2(x, 0));
            x = 0;
        }
        if (Input.GetButtonDown("tras")){
            x -= 150;
            ave.AddForce(new Vector2(x, 0));
            x = 0;
        }
        if(Input.GetButtonDown("cima")){
            y += 150;
            ave.AddForce(new Vector2(0, y));
            y = 0;
        }

        // if (Input.GetButtonDown("baixo")){
        //     y -= 300;
        //     ave.AddForce(new Vector2(0, y));
        //     y = 0;
        // }
	}
}
