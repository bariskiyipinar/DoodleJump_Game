using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    
   
    void OnTriggerEnter2D(Collider2D temas)
    {
        float rasgeleX = Random.Range(-5f, 5f);
        /*float rastgeleY = Random.Range(9f);*/ //Y ekseninde arada çok mesafe olmasýn diye sabit verdik.



        if (temas.tag == "Platform")
        {
            temas.transform.position = new Vector3(rasgeleX, temas.transform.position.y + 9f, temas.transform.position.z);
        }
    }
}
