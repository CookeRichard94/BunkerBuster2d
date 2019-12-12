using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript2 : MonoBehaviour
{
    private int health = 50;
    
    private int value = 300;


    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject playerBullet;
    public GameObject player;

    // Consistently calls the shoot method
    void Start()
    {
        InvokeRepeating("shoot", 0.5f, 2f);
    }

    // Method to have the enemy constantly aiming at the player
    void Update()
    {
        Vector3 targetPosition = player.transform.position;
        Vector3 dir = targetPosition - this.transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        Quaternion.Euler(0f,0f,angle * Mathf.Rad2Deg - 90f);
    }

    //Adds force to the enemy bullets
    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * 15f, ForceMode2D.Impulse);
        
    }

    //method to hurt the enemy and when enemy reaches 0 health destory it and add score to the player
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
