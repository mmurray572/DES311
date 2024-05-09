using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrapManager : MonoBehaviour {

    public AttributesManager SpikeTrapAtm;
    public AttributesManager playerAtm;
    public AttributesManager LavaTrapAtm;
    public AttributesManager LavaRingAtm;


    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "SpikeTrap") {
            SpikeTrapAtm.DealDamage(playerAtm.gameObject);
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay (Collider other) {
        if (other.gameObject.tag == "LavaTrap") {
            LavaTrapAtm.DealDamage(playerAtm.gameObject);
            Debug.Log("slow");
        }
        if (other.gameObject.tag == "LavaRing") {
            LavaRingAtm.DealDamage(playerAtm.gameObject);
            Debug.Log("slow");
        }
    }
}