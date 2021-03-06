﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdeath : MonoBehaviour 
{
     public int lives = 3;

    Vector3 startPosition;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EnemyProjectile(Clone)")
        {
            --lives;
            if (lives <= 0)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
            }
            transform.position = startPosition;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        OnTriggerEnter(collision.collider);
    }



    // Use this for initialization
    void Start ()
    {
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    { 

	}
}
