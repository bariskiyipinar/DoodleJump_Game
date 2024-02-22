using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jumppower;
    private Vector2 characterspeed;
    private Rigidbody2D fizik;

    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.relativeVelocity.y <= 0) { //y ekseninde haraket ederken 0'�n alt�na d��meden yeni kuvvet uygulamas�n diye yazd�k.
       fizik=temas.collider.GetComponent<Rigidbody2D>();

      if(fizik != null ){

        characterspeed=fizik.velocity;
        characterspeed.y = jumppower;
        fizik.velocity = characterspeed;
        }

        }
    }
}
