using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    private HingeJoint hinge;
    private string keyName;
    private bool rightFlipper = false;
    private bool leftFlipper  = false;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
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
    }

    void Update()
    {
        JointSpring spring = hinge.spring;

        if (Input.GetKey(keyName))
        {
            float val = (leftFlipper == true ? 1f : -1f);
            spring.spring = 10000;
            spring.damper = 30;
            spring.targetPosition = (-70)*val;
        }
        else
        {
            spring.targetPosition = 0f;
        }
        hinge.spring = spring;
    }
}
