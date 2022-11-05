using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
       if ( Input.GetKeyDown( KeyCode.DownArrow))
        {
            DamagePlayer(10);
        } 
    }

    public void DamagePlayer( int damage)
    {
        curHealth -= damage;
        healthBar = curHealth;
    }
}