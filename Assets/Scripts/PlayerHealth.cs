using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{

    public int health = 100;

    //Method to hurt player via enemy bullets which destroys the player if health reaches 0 and loads game over scene
    public void hurt(int damage)
    {
        health = health - damage;

        if(health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(6);
        }
            
          
    }

    // Method to add health to player via healthpack
    public void heal(int pickup)
    {
        health = health + pickup;

        //Caps health at 100
        if(health > 100)
        {
            health = 100;
        }
    }
}
