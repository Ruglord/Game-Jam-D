using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insanity_Bar : MonoBehaviour {

    public int insanity = 0;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("j"))
        {
            insanity = insanity + 10;
        }
        if (Input.GetKey("k"))
        {
            insanity = insanity + 15;
        }
        if (Input.GetKey("l"))
        {
            insanity = insanity + 20;
        }


	}
}
