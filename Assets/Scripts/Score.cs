using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int count;
    public Text scoreText;
    private string scoreStr;
    private int MAXSCORE = 9999999;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    void Update()
    {
        scoreStr = count.ToString();
        scoreText.text = scoreStr.PadLeft(7,'0');
    }

    public void IncreaseScore(int val)
    {
        if(count + val < MAXSCORE)
            count += val;
    }
}
