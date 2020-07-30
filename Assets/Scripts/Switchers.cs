using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchers : MonoBehaviour
{
    public GameObject[] switches;
    public Score score;
    public int switchBonus = 1000;

    private AudioSource audioSource;

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
        score.IncreaseScore(switchBonus);
        audioSource.Play();
    }
}
