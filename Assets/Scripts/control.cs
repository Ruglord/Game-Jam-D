using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    float speed = 2f;
    GameObject punch;
    BoxCollider2D punchBox;
    bool facing = true; //true is the main character is facing right, false if left
    coolDownComponent laser; //coolDownComponent for the laser;
    coolDownComponent teleport; //coolDownComponent for the teleport;
    coolDownComponent Heavy; //coolDownComponent for the heavy;

    coolDownComponent melee; //coolDownComponent for punches and kicks
	// Use this for initialization
	void Start () {
		punch = GameObject.Find("punchBox");
        punchBox = punch.GetComponent<BoxCollider2D>();
        melee = new coolDownComponent();
        melee.cooldown = 2f;
        laser = new coolDownComponent();
        laser.cooldown = .25f;

        teleport = new coolDownComponent();
        teleport.cooldown = 5;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 move = new Vector2(0,0);
		if (Input.GetKey("d"))
        {
            facing = true;
            move.x += speed;
        }
         if (Input.GetKey("a"))
        {
            facing = false;
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
        if (Input.GetKeyDown("q") || Input.GetKeyDown("e"))
        {
            if (melee.coolDownDone())
            {
                if(Input.GetKeyDown("q")){
                    punchBox.offset = new Vector2(1, 0.19f);
                    punchBox.enabled = true;
                }
                else{
                    punchBox.offset = new Vector2(1, -0.19f);
                    punchBox.enabled = true;
                }
            }
        }
        if (Input.GetKeyDown("j"))
        {
            
            if (laser.coolDownDone())
            {
                float angle = 0;
                if (!facing)
                {
                    angle = Mathf.PI; //if facing left, shoot left
                }
                gameObject.GetComponent<shooterComponent>().shoot(angle);
                laser.setCooldown();
            }
        }
        if (Input.GetKeyDown("k"))
        {
            if (teleport.coolDownDone())
            {
                float distance = 10;
                if (!facing)
                {
                    distance *= -1;
                }
                transform.position += new Vector3(distance,0,0);
            }
        }
	}
    private void OnDestroy()
    {
        print("ASDF");
    }
}
