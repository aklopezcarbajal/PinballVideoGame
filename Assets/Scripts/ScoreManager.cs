using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Score score;
    public int switchValue = 100;
    public int bumperValue = 50;
    public int slingshotValue = 30;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Switch"))
        {
            score.IncreaseScore(switchValue);
        }
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
