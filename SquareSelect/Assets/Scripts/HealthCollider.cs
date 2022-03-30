using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollider : MonoBehaviour
{
    public PowerUPEffect power;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        power.Action(collision.gameObject);
    }
}
