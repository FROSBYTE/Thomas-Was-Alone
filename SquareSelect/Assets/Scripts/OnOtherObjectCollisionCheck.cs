using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOtherObjectCollisionCheck : MonoBehaviour
{

 
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("player trigger");
            if ( collision.transform.position.y>transform.position.y)
            {
                Debug.Log("GameObject with PLayer Tag:" + collision.gameObject.name);

                Debug.Log("GameObject with no player Tag:" + transform.gameObject.name);
                transform.parent = collision.gameObject.transform;
            }

            // transform.parent = collision.transform.parent;


        }
    }
}
