using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private float health = 100;
    public Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / 100.00f;
    }

    public void TakeDamage(float damage)
    {
        health = health - damage;
        if (health < 1)
        {
            Destroy(gameObject);
        }
    }
}
