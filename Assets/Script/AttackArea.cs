using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 3;

    private void OnTriggerEnter (Collider collider) {
        if (collider.GetComponent<PlayerHealth>() != null) {
            PlayerHealth health = collider.GetComponent<PlayerHealth>();
            health.Damage(damage);
        }
    }

}
