using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
     Text textbox;
     public GameObject player;
 
        // Outputs the player health on the top left of the screen on start
        void Start()
        {
            textbox = GetComponent<Text>();
            textbox.text ="Health: " +  player.GetComponent<PlayerHealth>().health;  
        }

        //Outputs the updated player health as the player takes damage or regains health
        void Update()
        {
            textbox.text ="Health: " + player.GetComponent<PlayerHealth>().health;               
        }
}
