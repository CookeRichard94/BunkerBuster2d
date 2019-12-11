using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{

    public int health = 100;

    public void hurt(int damage)
    {
        health = health - damage;

        if(health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(6);
        }
            
          
    }

    public void heal(int pickup)
    {
        health = health + pickup;

        if(health > 100)
        {
            health = 100;
        }
    }
}
