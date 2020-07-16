using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerController : MonoBehaviour
{
    private Rigidbody ballRB;
    private bool ballReady;
    private float force;
    private float minForce = 0f;
    private float maxForce = 10000f;


    void Start()
    {
        ballRB = GameObject.Find("Ball").GetComponent<Rigidbody>();
        ballReady = false;
        force = 0f;
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
                force += 500f * Time.deltaTime;
        }
        if (Input.GetKeyUp("space") && ballReady)
        {
            print("Hit ball.");
            print(force);
            ballRB.AddForce( Vector3.forward * force);
            force = 0f;
        }
        
    }
}
