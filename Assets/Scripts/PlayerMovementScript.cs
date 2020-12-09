/*
References
https://www.youtube.com/watch?v=Q4rtR8iNFbY
https://www.youtube.com/watch?v=WPnX2qWzZvA
https://www.codegrepper.com/code-examples/delphi/unity+3d+player+movement
https://docs.unity3d.com/ScriptReference/CharacterController-isGrounded.html
https://docs.unity3d.com/ScriptReference/CharacterController.Move.html
https://www.youtube.com/watch?v=Ws1B1AGm-oM
https://www.youtube.com/watch?v=chuJ_XIxbhk
https://unitygamescripts.wordpress.com/2017/03/28/simple-jump-script-for-unity3d/

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public Rigidbody myRidBod;
    public float speed = 3;

    float horizontalInput;
    public float horizontalMulti = 1.5f;

    private float jumpForce = 5.0f;
    private bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        myRidBod = GetComponent<Rigidbody>();
        onGround = true;
              
    }

    void FixedUpdate()
    {
        Vector3 forwardMovement = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMovement = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMulti;
        myRidBod.MovePosition(myRidBod.position + forwardMovement + horizontalMovement);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if(Input.GetButton("Jump") && onGround == true)
        {
            myRidBod.velocity = new Vector3(0f, jumpForce, 0f);
            onGround = false;
        }
      
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ground")){
            onGround = true;
        }
    }

    
}