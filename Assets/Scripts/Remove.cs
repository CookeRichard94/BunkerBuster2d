using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D colliaion)
    {
        Destroy(gameObject);
    }
}
