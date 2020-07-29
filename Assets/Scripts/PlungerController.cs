using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerController : MonoBehaviour
{
    private Rigidbody ballRB;
    private bool ballReady;
    private float force;
    private float maxForce = 10000f;

    private AudioSource audioSource;

    void Start()
    {
        ballRB = GameObject.Find("Ball").GetComponent<Rigidbody>();
        ballReady = false;
        force = 0f;

        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        ballReady = true;
    }

    private void OnTriggerExit(Collider other)
    {
        ballReady = false;
    }
    
    void Update()
    {
        if (Input.GetKey("space") && ballReady)
        {
            if (force < maxForce) 
                force += 1500f * Time.deltaTime;
        }
        if (Input.GetKeyUp("space") && ballReady)
        {
            ballRB.AddForce( Vector3.forward * force);
            force = 0f;
            audioSource.Play();
        }
        
    }
}
