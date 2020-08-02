using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchState : MonoBehaviour
{
    public bool isOn;

    private Material switchMaterial;
    public Color switchOn;
    public Color switchOff;

    public Score score;
    public int switchValue = 100;

    void Start()
    {
        isOn = false;
        switchMaterial = GetComponent<MeshRenderer>().material;
        switchMaterial.color = switchOff;
    }

    private void OnTriggerEnter(Collider other)
    {
        score.IncreaseScore(switchValue);
        ChangeState();
    }

    public void ChangeState()
    {
        if (isOn)
        {
            isOn = false;
            switchMaterial.color = switchOff;
        }
        else
        {
            isOn = true;
            switchMaterial.color = switchOn;
        }
    }
}
