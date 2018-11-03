using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthComponent : MonoBehaviour {
    public double health = 0;
	// Use this for initialization
	void Start () {
		
	}
	public void takeDamage(double damage)
    {
        health -= damage;
    }
	// Update is called once per frame
	void Update () {
		if (health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
