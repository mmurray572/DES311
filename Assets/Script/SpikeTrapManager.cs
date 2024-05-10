using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrapManager : MonoBehaviour {

    public AttributesManager SpikeTrapAtm;
    public AttributesManager PlayerAtm;
    public AttributesManager LavaTrapAtm;
    public AttributesManager LavaRingAtm;

    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "SpikeTrap") {
            SpikeTrapAtm.DealDamage(PlayerAtm.gameObject);
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay (Collider other) {
        if (other.gameObject.tag == "LavaTrap") {
            LavaTrapAtm.DealDamage(PlayerAtm.gameObject);
        }
        if (other.gameObject.tag == "LavaRing") {
            LavaRingAtm.DealDamage(PlayerAtm.gameObject);
        }
    }
}