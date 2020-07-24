using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int maxBalls = 3;
    private Vector3 initialPosition;
    public float lowerBound = -20;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < lowerBound && maxBalls > 0)
        {
            maxBalls -= 1;
            transform.position = initialPosition;
        }
    }
}
