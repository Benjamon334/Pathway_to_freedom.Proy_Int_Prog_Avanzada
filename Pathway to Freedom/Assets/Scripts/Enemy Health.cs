using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int health = 5;

    private int MAX_HEALTH = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            //Heal(1);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            //Damage(1);
        }
    }

    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }

    public void Damage(int amount)
    {
        if(amount < 0) {
            throw new System.ArgumentOutOfRangeException("Damage amount cannot be negative");
        }

        this.health -= amount;

        if(health <= 0) {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if(amount < 0) {
            throw new System.ArgumentOutOfRangeException("Heal amount cannot be healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if(wouldBeOverMaxHealth) {
            this.health = MAX_HEALTH;
        }
        else {
            this.health += amount;
        }

        
    }

    private void Die()
    {
        Debug.Log("Entity has died.");
        Destroy(gameObject);
    }
}
