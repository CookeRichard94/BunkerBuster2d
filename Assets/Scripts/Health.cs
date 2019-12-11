using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
     Text textbox;
     public GameObject player;
 
        void Start()
        {
            textbox = GetComponent<Text>();
            textbox.text ="Health: " +  player.GetComponent<PlayerHealth>().health;  
        }

        void Update()
        {
            textbox.text ="Health: " + player.GetComponent<PlayerHealth>().health;               
        }
}
