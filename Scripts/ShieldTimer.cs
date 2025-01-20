using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldTimer : MonoBehaviour
{
    public Slider slider;
   
    void Start()
    {
        slider.value = slider.minValue;
        
    }

    public void Slidertimer()
    {
           
        slider.value = slider.maxValue;  
            
            

    }
}
