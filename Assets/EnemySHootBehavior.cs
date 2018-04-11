using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySHootBehavior : MonoBehaviour {
    public GameObject shoot;
    public float shootdelay;
    float timer;
    public float speed;
    public float spawnDistance;
    // Use this for initialization
    void Start()
    {

    }

    void shot()
    {
        GameObject baby = Instantiate(shoot);
        Rigidbody2D Rb = baby.GetComponent<Rigidbody2D>();
        Rb.velocity = transform.up * speed;
        baby.transform.position = transform.position + (spawnDistance * transform.up);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            shot();
            timer = shootdelay;
        }
    }
}
