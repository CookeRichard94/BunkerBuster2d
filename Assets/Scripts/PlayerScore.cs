using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;

    //Method to add score to the players score on each level
    public void add(int newScore)
    {
        score = score + newScore;
    }
}
