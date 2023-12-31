using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Transform healthBar;
    public int maxHealth = 100;
    private int health;

    private void Start()
    {
        health = maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 100;
            transform.position = new Vector3(3, 1.090001f, 3);

        }
        healthBar.localScale = new Vector3((float)health / maxHealth, 1, 1);
    }
}
