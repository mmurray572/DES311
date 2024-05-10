using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrapManager : MonoBehaviour
{
    public AttributesManager SpikeTrapAtm;
    public EnemyAttributesManager EnemyAtm;
    public AttributesManager LavaTrapAtm;
    public AttributesManager LavaRingAtm;

    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "SpikeTrap") {
            SpikeTrapAtm.DealDamage(EnemyAtm.gameObject);
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay (Collider other) {
        if (other.gameObject.tag == "LavaTrap") {
            LavaTrapAtm.DealDamage(EnemyAtm.gameObject);
        }
        if (other.gameObject.tag == "LavaRing") {
            LavaRingAtm.DealDamage(EnemyAtm.gameObject);
        }
    }
}
