using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    //Method to load specified scene

    public void loadNextLevel(int num){
        SceneManager.LoadScene(num);
    }
}
