using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Pauses and resusmes the game on pressing of the space bar
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                {
                    Pause();
                }
            }
        }
        
    }

    //Resumes game after it has been paused
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    //Pauses game by setting tiemscale o 0
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    //Loads the main menu scene
    public void LoadMenu()
    {
        Debug.Log("Loading");
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    //Quits the application
    //Only works when build is run
    public void Quit()
    {
        Application.Quit();
    }
}
