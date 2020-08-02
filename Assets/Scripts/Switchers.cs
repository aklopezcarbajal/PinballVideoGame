using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchers : MonoBehaviour
{
    public GameObject[] switches;
    private bool allSwitchesOn = false;
    public Score score;
    public int switchBonus = 1000;

    private AudioSource audioSource;

    public float waitTime = 0.2f;
    public float timer = 0.0f;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //If all the swithces are ON, the player gets a bonus
        for (int i = 0; i < switches.Length; i++)
        {
            if (!switches[i].GetComponent<SwitchState>().isOn)
                return;
        }
        allSwitchesOn = true;
        if (allSwitchesOn)
        {
            timer += Time.deltaTime;
            if (timer > waitTime)
            {
                AllSwitchesOn();
            }
        }
    }

    //Play bonus clip, increase score and turn switches OFF
    void AllSwitchesOn()
    {
        allSwitchesOn = false;
        audioSource.Play();
        score.IncreaseScore(switchBonus);

        for (int i = 0; i < switches.Length; i++)
        {
            switches[i].GetComponent<SwitchState>().ChangeState();
        }
    }
}
