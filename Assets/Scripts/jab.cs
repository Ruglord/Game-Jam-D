using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jab : MonoBehaviour {
    float doittoemboi = 25.0f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var obj = collision.gameObject;
        var healish = obj.GetComponent<healthComponent>();
        healish.takeDamage(doittoemboi);
        print("hit dat bitch");
    }
}
