using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    float speed = 2f;
    GameObject punch;
    BoxCollider2D punchBox;
	// Use this for initialization
	void Start () {
		punch = GameObject.Find("punchBox");
        punchBox = punch.GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 move = new Vector2(0,0);
		if (Input.GetKey("d"))
        {
            move.x += speed;
        }
         if (Input.GetKey("a"))
        {
            move.x -=speed;
        }
         if (Input.GetKey("s"))
        {
            move.y -= speed;
        }
         if (Input.GetKey("w"))
        {
            move.y += speed;
        }
        transform.position += new Vector3(move.x,move.y,0) * Time.fixedDeltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            punchBox.enabled = true;
        }
	}
}
