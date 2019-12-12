using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    
// Loads the tutorial scene for the player to start again
    public void restart()
    {
        SceneManager.LoadScene(1);
    }

//loads the menu scene 
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
