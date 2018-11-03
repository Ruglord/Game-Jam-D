using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//universal shooting class. Any class that shoots anything can use this script.
public class shooterComponent : MonoBehaviour {
    public GameObject projectile;

	// Use this for initialization
	void Start () {
		
	}
	public void shoot(float angle)
    {
        GameObject proj = Instantiate(projectile, transform.position, Quaternion.identity);
        proj.GetComponent<Projectile>().angle = angle;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
