using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PlayersMovement : MonoBehaviour
{
    public MainMenu levelToLoad ;
    public GameManager manager;
    public float moveSpeed;
    private float maxSpeed = 15f;
   
    public GameObject deathParticles;
    public GameObject gameOver;
    private Vector3 input;
    private Vector3 spawn;
    public int lives = 1;
    public static PlayersMovement instance = null;

   

    private GameObject clonePaddle;

    

    // Use this for initialization
    void Start()
    {
        spawn = transform.position;
     
       

    }

    public void Setup()
    {
    //    clonePaddle = Instantiate (transform.position) as GameObject;
        Instantiate(transform.position, Quaternion.identity);
   }

    private void Instantiate(Vector3 position, Quaternion identity)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
        {
            GetComponent<Rigidbody>().AddForce(input * moveSpeed);
        }

        if (transform.position.y < -2)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnCollisionEnter(Collision other)
    
    {
     if (other.transform.tag == "Enemy")
        {
            SceneManager.LoadScene("GameOver");
        }  
    }

   

    void  OnTriggerEnter(Collider other)

    {
        if (other.transform.tag == "Enemy")
        {
            SceneManager.LoadScene("GameOver");
        }
       

        if (other.transform.tag == "Goal")
        {
           GameManager.CompleteLevel();
        }
    }

   

    void Die()
    {
    Instantiate(deathParticles, transform.position, Quaternion.Euler(270,0,0));
    transform.position = spawn;

    }
}