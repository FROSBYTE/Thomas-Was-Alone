using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckCollision : MonoBehaviour
{

    public bool isGrounded = false;

    private void Update()
    {
       // Debug.Log(isGrounded);
    }



/*    private void OnCollisionStay2D(Collision2D collision)
    {
     
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
       
    }*/
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log(isGrounded + "onStay");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }


}
