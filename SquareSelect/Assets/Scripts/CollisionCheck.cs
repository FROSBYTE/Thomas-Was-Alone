using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{

    public bool isGrounded = false;
    private ChangePlayer player;
    private void Start()
    {
        player=GameObject.FindGameObjectWithTag("PlayerHolder").GetComponent<ChangePlayer>();
    }
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
        //Happens when Non-PLayable Player is on Top
       
        if (collision.gameObject.CompareTag("Ground") )
        {
            isGrounded = true;
           // Debug.Log(isGrounded + "onStay");
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
