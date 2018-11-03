using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrcHealth : MonoBehaviour {
    public const float maxHealth = 100f;
    public float currentHealth = maxHealth;
    public void Start()
    {
    }
    public void Update()
    {
    }
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Destroy(gameObject);
        }
    }
}
