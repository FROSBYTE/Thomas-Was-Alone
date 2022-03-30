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
        healthSlider.interactable = false;
        GameManager.instance.onGameStart.AddListener(delegate
        {
            health = maxHealth;
            DisplayHealth(100f);
           
        });
    }

    public void DisplayHealth(float health)
    {
        healthSlider.value = health;
    }
    
}
