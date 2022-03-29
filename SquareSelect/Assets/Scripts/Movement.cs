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





    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");
        if(!canJump && Input.GetKey(KeyCode.Space))
        {
            canJump = true;
        }
         
    }
    private void FixedUpdate()
    {
        pos = transform.position;
        pos.x += horizontalInput * movementSpeed * Time.deltaTime;
        if (canJump)
        {
            rigidbody.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            canJump = false;
        }
       
        //Debug.Log(pos);
        this.transform.position = pos;
    }


}
