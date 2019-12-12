using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankScript : MonoBehaviour
{

    private int health = 300;
    
    private int value = 2000;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject playerBullet;
    public GameObject player;

    // Has the tank constantly firing t regular intervals
    void Start()
    {
        InvokeRepeating("shoot", 0.5f, 2f);
    }

    // Method to have the tank aim at the player
    void Update()
    {
         Vector3 targetPosition = player.transform.position;
        Vector3 dir = targetPosition - this.transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        Quaternion.Euler(0f,0f,angle * Mathf.Rad2Deg - 90f);
    }

    // Dhoot method adds force to the tanks bullets
    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * 15f, ForceMode2D.Impulse);
        
    }

    // Method to decrease the tanks health where if health is reduced to 0 the tank is destroyed, the win scene is loaded and the score added to the players
     public void hurt(int damage)
    {
        health = health - damage;

        if(health <= 0)
        {
            Destroy(gameObject);

            player.GetComponent<PlayerScore>().add(value);

            SceneManager.LoadScene(7);
            
        }
            
          
    }
}
