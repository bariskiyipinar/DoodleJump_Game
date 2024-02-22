using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D Doodle;
    private float moveinput;
    public TextMeshProUGUI ScoreText;
    private int Score;
   

  
    void Update()
    {
        moveinput = Input.GetAxis("Horizontal");
        Doodle.velocity=new Vector2(speed*moveinput,Doodle.velocity.y);

        ScoreText.text = "Score:" + Score;
    }

     void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Final")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        if(temas.gameObject.tag == "Platform")
        {
            Score += Random.Range(10, 50);
        }
        
    }


}
