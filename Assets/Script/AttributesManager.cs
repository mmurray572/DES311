using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{

    [Header("Stats")]
    public int health;
    public int attack;
    public int armour;

    public void TakeDamage (int amount) {
        armour -= amount;
        
        if (armour <= 0)
            health -= amount;

        if (health <= 0) {
            transform.position = new Vector3(0,6,0);
            health = 150;
            armour = 150;
        }
    }

    public void DealDamage (GameObject target) {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null) {
            atm.TakeDamage(attack);
        }
    }

}
