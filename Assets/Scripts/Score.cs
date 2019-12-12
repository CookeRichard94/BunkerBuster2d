using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text textbox;
    public GameObject player;
    
    //Method to display player score on top right corner
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text ="Score: " +  player.GetComponent<PlayerScore>().score;
    }

    // Method to display updated playerscore
    void Update()
    {
        textbox.text ="Score: " +  player.GetComponent<PlayerScore>().score;
    }
}
