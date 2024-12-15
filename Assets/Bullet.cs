using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
        public float lifeTime = 3f;

     void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Bullet collided with: " + other.gameObject.name + ", Tag: " + other.tag);

        // get the ScoreManager instance
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

        if (other.CompareTag("Bomb"))
        {
            // destroy the bomb and add points
            scoreManager.AddPoints(10);
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }
        else if (other.CompareTag("Apple"))
        {
            // destroy apple and penalize
            scoreManager.AddPoints(-5);
            Destroy(other.gameObject);
            Destroy(gameObject);
           
        }
    }
}