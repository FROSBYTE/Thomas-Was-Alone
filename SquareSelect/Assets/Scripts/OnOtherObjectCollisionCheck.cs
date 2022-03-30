using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOtherObjectCollisionCheck : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            if (transform.position.y > collision.transform.position.y)
            {
                Debug.Log("GameObject with PLayer Tag:" + collision.gameObject.name);

                Debug.Log("GameObject with no player Tag:" + transform.gameObject.name);
                transform.parent = collision.gameObject.transform;
            }
            
            // transform.parent = collision.transform.parent;


        }
    }
}
