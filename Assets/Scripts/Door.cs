using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    
   // Loads the next scene when the object tagged player hits the door
    void OnTriggerEnter2D(Collider2D other)
      {
          if (other.gameObject.tag == "Player")
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }
        
        
}
