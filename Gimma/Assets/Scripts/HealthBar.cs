using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public Slider slider;
    
    public void SetMaxAmount(float amount){
        slider.maxValue = amount;
    }
    public void SetAmount(float amount){
        slider.value =  amount;
    }
}
