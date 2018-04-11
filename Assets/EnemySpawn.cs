using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject spawn;
    public float range;
    public float spawnInterval;
    public float spawntimer;
    // Use this for initialization
    void Start()
    {

    }

    void spawnEnemy()
    {
        GameObject spawnedEnemy = Instantiate(spawn);
        float randY = Random.Range(-range, range);
        spawnedEnemy.transform.position = transform.position + new Vector3(0, randY);
    }

    // Update is called once per frame
    void Update()
    {
        spawntimer -= Time.deltaTime;
        if (spawntimer <= 0)
        {
            spawntimer = spawnInterval;
            spawnEnemy();
        }
    }
}
