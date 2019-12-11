using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    private int health = 30;
    
    private int value = 100;

    public float interval = 2f;
    public float bulletForce = 0.05f;

    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject playerBullet;
    public GameObject player;

    // Update is called once per frame
    void Start()
    {
       InvokeRepeating("shoot", 2.0f, 3f);
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * bulletForce;
        
    }

    public void hurt(int damage)
    {
        health = health - damage;

        if(health <= 0)
        {
            Destroy(gameObject);

            player.GetComponent<PlayerScore>().add(value);
        }
            
          
    }
    
}
