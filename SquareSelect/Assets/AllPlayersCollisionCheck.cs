using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPlayersCollisionCheck : MonoBehaviour
{
    private Transform playersHolder;
    private int totalPlayers;
    private int totalPlayerAlreadyEntered=0;
    // Start is called before the first frame update
    void Start()
    {
        playersHolder=GameObject.FindGameObjectWithTag("PlayerHolder").GetComponent<Transform>();
        totalPlayers = playersHolder.childCount;
        Debug.Log("Total Player " + totalPlayers);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.tag = "Untagged";
            SelectPlayer player= collision.gameObject.GetComponent<SelectPlayer>();
            collision.gameObject.SetActive(false);
            if(totalPlayers>1)
            {
                if(player.Index==0)
                {
                    playersHolder.GetComponent<ChangePlayer>().changePlayer(1);
                    
                }
                else
                {
                    playersHolder.GetComponent<ChangePlayer>().changePlayer(0);
                }
                
            }
            //player.enabled= false;
            //Rigidbody2D rigidbody= player.GetComponent<Rigidbody2D>();
            //rigidbody.isKinematic= true;
            //Movement playerMovement= collision.gameObject.GetComponent<Movement>();
            //playerMovement.enabled= false;
            //BoxCollider2D collider = player.GetComponent<BoxCollider2D>();
            //collider.enabled= false;
            totalPlayerAlreadyEntered=totalPlayerAlreadyEntered+1;
            Debug.Log(totalPlayerAlreadyEntered);
            
            
        }
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if(totalPlayerAlreadyEntered>=totalPlayers)
        {
            UiManager.instance.LevelUp();
        }
    }
}
