/*
References

https://www.youtube.com/watch?v=Q4rtR8iNFbY
https://www.youtube.com/watch?v=WPnX2qWzZvA
https://www.codegrepper.com/code-examples/delphi/unity+3d+player+movement
https://docs.unity3d.com/ScriptReference/CharacterController-isGrounded.html
https://docs.unity3d.com/ScriptReference/CharacterController.Move.html

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,3);

    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
/*
    //CharacterController controller;

    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float speed = 3.0f;

    float gravityScaleAtStart;

    Rigidbody myRidBod;
    //private Vector3 moveXDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

        myRidBod = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,3);
        
        
       // controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        Jump();
        XMovement();
        //below code is make the player move to side to side and jump 
        //var horizontal = Input.GetAxis("Horizontal");

        /*    
        transform.Translate(new Vector3(horizontal, 0) * (speed * Time.deltaTime));
        
        if(controller.isGrounded)
        {
            moveXDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f);
            moveXDirection *= speed;

            if(Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }

        }

        moveXDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveXDirection * Time.deltaTime);*/
        
    //}
    /*


    private void XMovement()
    {
        float xDir = Input.GetAxis("Horizontal");
        Vector3 playerVel = new Vector3(xDir*speed, myRidBod.velocity.y);
        myRidBod.velocity = playerVel;

        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    private void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Vector3 jumpVelToAdd = new Vector3(0f, jumpSpeed);
            myRidBod.velocity += jumpVelToAdd;
        }
    }
*/
  
}
