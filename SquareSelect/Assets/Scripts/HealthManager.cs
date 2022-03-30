using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] float health = 100f;
     public Slider healthSlider;

    private void Start()
    {
        healthSlider.interactable = false;
    }

    public void DisplayHealth(float health)
    {
        healthSlider.value = health;
    }
    
}
