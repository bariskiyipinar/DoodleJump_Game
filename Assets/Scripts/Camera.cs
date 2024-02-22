using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Character;
  

    
    void Update()
    {
        if(Character.position.y>transform .position.y)
        {
            transform .position = new Vector3(transform.position.x,Character.position .y,transform.position.z);
        }
    }
}
