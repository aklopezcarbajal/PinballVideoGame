using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 1000f;
    private string keyName;
    private bool rightFlipper = false;
    private bool leftFlipper  = false;

    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (transform.position.x < 0)
        {
            leftFlipper = true;
            keyName = "left";
        }
        if (transform.position.x > 0)
        {
            rightFlipper = true;
            keyName = "right";
        }

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(keyName))
        {
            rb.AddForce(transform.forward * force);
        }
        if (Input.GetKeyDown(keyName))
        {

            audioSource.Play();
        }
    }
}
