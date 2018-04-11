using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    Rigidbody2D Rb;
    public float speed = 2;

	// Use this for initialization
	void Start ()
    {
        Rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Rb.velocity = -transform.up * speed;
    }
}
