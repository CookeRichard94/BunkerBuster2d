using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text textbox;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text ="Score: " +  player.GetComponent<PlayerScore>().score;
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text ="Score: " +  player.GetComponent<PlayerScore>().score;
    }
}
