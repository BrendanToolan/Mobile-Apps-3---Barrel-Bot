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
    Rigidbody myRidBod;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

        
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,3);
        myRidBod = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xMovement();
    }

    private void xMovement()
    {
        float horizontalM = Input.GetAxis("Horizontal");
        float verticalM = Input.GetAxis("Vertical");
        myRidBod.velocity = new Vector3 (horizontalM * speed, myRidBod.velocity.y, verticalM * speed);
    }
}
