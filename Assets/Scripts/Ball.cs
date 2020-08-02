using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int balls;
    private Vector3 initialPosition;
    public float lowerBound = -20;

    public Score score;
    public int bumperValue = 50;
    public int slingshotValue = 30;

    public GameManager gameManager;

    void Start()
    {
        balls = 3;
        initialPosition = transform.position;
    }

    void Update()
    {
        //Reset the ball position when it exits the payfield
        if (transform.position.z < lowerBound)
        {
            balls -= 1;
            if (balls > 0)
                transform.position = initialPosition;
            else
                gameManager.GameOver();
        }
      
           
    }

    //Increase score when the ball collides with bumpers and slingshots
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bumper"))
        {
            score.IncreaseScore(bumperValue);
        }
        else if (collision.gameObject.CompareTag("Slingshot"))
        {
            score.IncreaseScore(slingshotValue);
        }
    }
}
