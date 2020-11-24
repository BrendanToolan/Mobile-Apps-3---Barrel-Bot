/*
References

https://www.youtube.com/watch?v=Q4rtR8iNFbY
https://www.youtube.com/watch?v=WPnX2qWzZvA
https://www.codegrepper.com/code-examples/delphi/unity+3d+player+movement
https://docs.unity3d.com/ScriptReference/CharacterController-isGrounded.html
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    CharacterController controller;

    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float speed = 6.0f;

    private Vector3 moveXDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,3);
       // controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //below code is make the player move to side to side and jump 
      /*  var horizontal = Input.GetAxis("Horizontal");

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
        controller.Move(moveXDirection * Time.deltaTime);
        */
    }
  
}
