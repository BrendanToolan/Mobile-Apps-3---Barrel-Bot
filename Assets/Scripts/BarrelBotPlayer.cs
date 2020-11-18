using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelBotPlayer : MonoBehaviour
{

    [SerializeField] float jumpSpeed = 15.0f;
    [SerializeField] float horizontalMovementSpeed = 15.0f;

    Rigidbody myRigidBody;

    float gravityScaleAtStart;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();

       // gravityScaleAtStart = myRigidBody.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void Movement()
    {
        float xDir = Input.GetAxis("Horizontal");
        Vector3 playerVel = new Vector3(xDir*horizontalMovementSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = playerVel;

        bool playerCanMoveLeftandRight = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
        if(playerCanMoveLeftandRight)
        {
            transform.localScale = new Vector3(Mathf.Sign(myRigidBody.velocity.x), 15.0f);
        }
        else{

        }
    }

    private void Jump(){
        if(Input.GetButtonDown("Jump"))
        {
            // change velocity in y direction
            Vector3 jumpVelocityToAdd = new Vector3(0f, jumpSpeed);
            myRigidBody.velocity += jumpVelocityToAdd;
        }
    }
}
