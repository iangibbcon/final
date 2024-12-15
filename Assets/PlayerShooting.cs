using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;     //should be right above the playeer
    public float bulletSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }  
     void Shoot()
    {
        // instantiate on top of the player or wherever I want
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // the bullet moves upwards at bulletspeed speed
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.up * bulletSpeed;
        }
    }
}
}