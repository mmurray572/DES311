using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private int MAX_HEALTH = 100;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage (int amount) {
        if (amount < 0) {
            throw new System.ArgumentOutOfRangeException("cannot have negative damage");
        }

        this.health -= amount;
    }

    public void Heal (int amount) {
        if (amount < 0) {
            throw new System.ArgumentOutOfRangeException("cannot have negative healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if (wouldBeOverMaxHealth) {
            this.health = MAX_HEALTH;
        }
        else {
            this.health += amount;
        }

    }
}
