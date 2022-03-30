using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="HealthBuff/PowerUp")]

public class HealthBuff : PowerUPEffect
{

     public float amount;
    public override void Action(GameObject target)
    {
        target.GetComponent<HealthManager>().healthSlider.value += amount;
    }
}
