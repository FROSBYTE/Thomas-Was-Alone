using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthreduction : MonoBehaviour
{
    public Slider healthSlider;
    [SerializeField]
    private float deductHealth = 10f;

    void Start()
    {
        //StartCoroutine("DeductionofPlayerHealth");
        
    }
    private void Update()
    {
        if(healthSlider.value == 0)
        {
            GameManager.instance.OnGameEnd?.Invoke();
        }
    }

    public IEnumerator DeductionofPlayerHealth()
    {
        while (true)
        {
            healthSlider.value -= deductHealth;
            yield return new WaitForSeconds(2f);
        }
    }


}
