using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthbar : MonoBehaviour
{
    [SerializeField] Slider slider;

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void MaxHealth(int maxHealth)
    {
        slider.maxValue = maxHealth;
    }
}