using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrapManager : MonoBehaviour
{
    public AttributesManager SpikeDamage;

    private void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Player"){
            Destroy(gameObject);
        }

    }
}
