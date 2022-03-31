using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Move
    private float horizontalInput;
    [SerializeField]
    float movementSpeed;
    Vector3 pos;
    //Jump
    [SerializeField]
    float jumpHeight;
    //private float verticalInput;
    private bool canJump = false;
    Rigidbody2D rigidbody;

    [SerializeField]
    private CollisionCheck collisionCheck;

    [SerializeField]
    float gravity = 0.05f;
    //public bool isGrounded;





    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collisionCheck = transform.GetChild(1).GetComponent<CollisionCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");
        if(!canJump && Input.GetKey(KeyCode.Space) &&collisionCheck.isGrounded)
        {
            canJump = true;

        }
        /*Debug.Log(rigidbody.velocity);
        if(collisionCheck.isGrounded == false && rigidbody.velocity.y <= 1)
        {
            rigidbody.AddForce(new Vector2(0, -90f * Time.deltaTime), ForceMode2D.Impulse);
        }*/
        // Debug.Log(collisionCheck.isGrounded);
        //Debug.Log(canJump);
         
    }
    private void FixedUpdate()
    {
        pos = transform.position;
        pos.x += horizontalInput * movementSpeed * Time.deltaTime;

        if (canJump)
        {
            AudioManager.Instance.onPlayerJumped?.Invoke();
            rigidbody.velocity = new Vector2(0, jumpHeight);
            //rigidbody.AddForce(new Vector2(0, jumpHeight*Time.deltaTime), ForceMode2D.Impulse);
            /*LeanTween.scale(this.gameObject, new Vector3(1, 1.5f, 1), 1f).scale(this.gameObject, new Vector3(1, 1.5f, 1), 1f);
            LeanTween.ease*/
            //LeanTween.scale(this.gameObject, new Vector3(1, 1f, 1), 1f);
            canJump = false;
        }
       
        //Debug.Log(pos);
        this.transform.position = pos;
    }
    
  


}
