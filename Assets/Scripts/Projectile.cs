using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
   public float angle = 0; //this angle is in RADIANS. C# does angles in radians while unity does angles in degrees.
   public float speed = .1f;
   public static float damage = 5f;
    public bool isEnemy = false;
	// Use this for initialization
 /*   public Projectile(float x, float y,float radians, float s)
    {
        transform.position = new Vector3(x,y,0);
        angle = radians;
        speed = s;
    }*/
	void Start () {
        speed = .1f;
	}
	// Update is called once per frame
	void Update () {
        if (gameObject != null)
        {
            transform.eulerAngles = new Vector3(0, 0, angle * 180 / Mathf.PI - 90);
            transform.position += new Vector3(Mathf.Cos(angle) * speed, Mathf.Sin(angle) * speed, 0);
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var obj = collision.gameObject;
        if ((collision.gameObject.GetComponent<EnemyOrcAi>() != null && !isEnemy)) //If the enemy has the enemy AI, it's an enemy
        {
            obj.GetComponent<healthComponent>().takeDamage(damage);
        }
    }
    void OnBecameInvisible()
    {
        if (gameObject != null)
        {
            Destroy(gameObject);
        }

    }

    }

