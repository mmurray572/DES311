using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{

    public AttributesManager playerAtm;
    public AttributesManager regEnemyAtm;
    public AttributesManager agileEnemyAtm;
    public AttributesManager berserkerEnemyAtm;



    private void Update()
    {
        //deal player damage to enemy
        if (Input.GetKeyDown(KeyCode.Z)) {
            playerAtm.DealDamage(regEnemyAtm.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.X)) {
            playerAtm.DealDamage(agileEnemyAtm.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.C)) {
            playerAtm.DealDamage(berserkerEnemyAtm.gameObject);
        }


        //deal enemy damage to player
        if (Input.GetKeyDown(KeyCode.V)) {
            regEnemyAtm.DealDamage(playerAtm.gameObject);
        }
    }
}
