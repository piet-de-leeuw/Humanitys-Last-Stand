using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUntilLastStand : MonoBehaviour
{

    public bool hasEnded = false;
    
    Slider slider;

    void Start()
    {
        hasEnded = false;
        slider = GetComponent<Slider>();
        slider.value = slider.maxValue;
    }


    void Update()
    {
        slider.value -= Time.deltaTime;
        if(slider.value <= 0f)
        {
            hasEnded = true;
        }
    }
}
