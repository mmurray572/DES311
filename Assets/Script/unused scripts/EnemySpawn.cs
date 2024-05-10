using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public Transform[] SpawnPoint;
    public GameObject EnemyPrefab;

    void Start () {
        SpawnEnemy();
    }

    void SpawnEnemy () {
        Instantiate(EnemyPrefab, SpawnPoint[0].transform.position, Quaternion.identity);
    }
}
