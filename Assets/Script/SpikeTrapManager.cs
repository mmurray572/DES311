using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrapManager : MonoBehaviour {

    public AttributesManager SpikeTrapAtm;
    public AttributesManager playerAtm;
    public AttributesManager LavaAtm;

    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "SpikeTrap") {
            SpikeTrapAtm.DealDamage(playerAtm.gameObject);
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay (Collider other) {
        if (other.gameObject.tag == "LavaTrap") {
            LavaAtm.DealDamage(playerAtm.gameObject);
            Debug.Log("slow");
        }
        if (other.gameObject.tag == "LavaRing") {
            LavaAtm.DealDamage(playerAtm.gameObject);
            Debug.Log("slow");
        }
    }
}