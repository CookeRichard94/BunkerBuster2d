using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove2 : MonoBehaviour
{

    
    private int damage = 30;

    //Method for boss bullets that deal extra damage
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        // For enemies to kill player
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().hurt(damage);

        }
    }
}
