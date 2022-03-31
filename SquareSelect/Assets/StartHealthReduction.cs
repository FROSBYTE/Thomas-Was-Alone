using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartHealthReduction : MonoBehaviour
{
    [SerializeField]
    public Slider healthSlider;

    [SerializeField]
    Healthreduction healthreduction;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(healthreduction.DeductionofPlayerHealth());
    }

    // Update is called once per frame
    void Update()
    {
        if (healthSlider.value == 0)
        {
            GameManager.instance.OnGameEnd?.Invoke();
        }
    }
}
