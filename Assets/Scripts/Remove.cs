using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    private int damage = 10;
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        // For player to kill enemies
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<TurretScript>().hurt(damage);

        }

        // For enemies to kill player
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().hurt(damage);

        }

        if(collision.gameObject.tag == "Enemy2")
        {
            collision.gameObject.GetComponent<TurretScript2>().hurt(damage);   
        }

        if(collision.gameObject.tag == "Boss")
        {
            collision.gameObject.GetComponent<TankScript>().hurt(damage);   
        }

    }
}
