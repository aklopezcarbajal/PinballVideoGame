using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    void Update()
    {
    }

    public void IncreaseScore(int val)
    {
        count += val;
    }
}
