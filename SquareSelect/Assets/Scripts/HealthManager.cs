using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] float health = 5f;
    public Slider healthSlider;
    private float maxHealth = 100f;


    private void Awake()
    {
        health = maxHealth;
        healthSlider.value = health;

        
    }
  

 

    public void DisplayHealth(float health)
    {
        healthSlider.value = health;
    }
    
}
