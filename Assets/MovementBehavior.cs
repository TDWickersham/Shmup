using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour {
    Rigidbody2D Rb;
    public float speed = 5;
    public float maxY = 4.5f;
    public float maxX = 7.7f;
	// Use this for initialization
	void Start ()
    {
        Rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float vert = Input.GetAxis("Vertical");
        float hori = Input.GetAxis("Horizontal");

        Rb.velocity = ((Vector2.up * vert) + (Vector2.right * hori) * speed);

        Vector2 currentPos = transform.position;
        currentPos.y = Mathf.Clamp(currentPos.y, -maxY, maxY);
        currentPos.x = Mathf.Clamp(currentPos.x, -maxX, maxX);
        transform.position = currentPos;
	}
}
