using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform target;
 
     void Update () {
         transform.position = new Vector3(Mathf.Clamp(target.position.x,0f, 0f), Mathf.Clamp(target.position.y,0f, 50f), transform.position.z);
     }
}
