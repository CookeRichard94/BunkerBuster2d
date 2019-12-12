using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 30;
    public GameObject player;

    //Method for when the object with player tag collides with healthpack the pack is destroyed and the player regains 30 health
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<PlayerHealth>().heal(health);
        }
    }
}
