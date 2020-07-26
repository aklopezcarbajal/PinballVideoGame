using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchState : MonoBehaviour
{
    public bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isOn)
            isOn = false;
        else
            isOn = true;
        //print("Switch state");
       /// if (isOn)
            //print("Is ON");
        //else
            //print("Is OFF");
    }
}
