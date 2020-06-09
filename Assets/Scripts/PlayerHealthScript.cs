using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth;

    public HealthBarScript healthbar;
    void Start()
    {
        curHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Damage(10);
        }
    }

    void Damage (int damage)
    {
        curHealth -= damage;
        healthbar.SetHealth(curHealth);
    }
}
