using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this class is a utility class to all abilities that need a cooldown. It basically handles cooldowns.
public class coolDownComponent {
    public float cooldown;
    float startTime = 0;
	public void setCooldown() //sets the cooldown timer
    {
        startTime = Time.realtimeSinceStartup;
    }
    public bool coolDownDone() //returns true if the cooldown is over
    {
        return (Time.realtimeSinceStartup - startTime) >= cooldown;
    }

}
