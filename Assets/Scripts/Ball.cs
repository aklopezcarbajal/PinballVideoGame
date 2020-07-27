using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int maxBalls = 3;
    private Vector3 initialPosition;
    public float lowerBound = -20;

    public Score score;
    public int bumperValue = 50;
    public int slingshotValue = 30;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        //Reset the ball position when it exits the payfield
        if (transform.position.z < lowerBound && maxBalls > 0)
        {
            maxBalls -= 1;
            transform.position = initialPosition;
        }
    }

    //Increase score when the ball collides with bumpers and slingshots
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bumper"))
        {
            score.IncreaseScore(bumperValue);
            print("Bumper");
        }
        else if (collision.gameObject.CompareTag("Slingshot"))
        {
            score.IncreaseScore(slingshotValue);
            print("Slingshot");
        }
    }
}
