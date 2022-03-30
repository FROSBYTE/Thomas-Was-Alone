using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    private void Start()
    {
       /* GameManager.instance.OnGameEnd.AddListener(delegate
        {
            GameManager.instance.endGame();
        });*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.OnGameEnd?.Invoke();
            Destroy(collision.gameObject);
            
        }
    }
}
