using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour {
    float timer;
    public float lifetime;
    public int scoreValue = 10;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;

        if (timer >= lifetime)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            ScoreManager.score += scoreValue;
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }
    }
}
