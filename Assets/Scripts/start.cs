using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    // Starts the first level from the tutorial
    public void startGame()
    {
        SceneManager.LoadScene(2);
    }
}
