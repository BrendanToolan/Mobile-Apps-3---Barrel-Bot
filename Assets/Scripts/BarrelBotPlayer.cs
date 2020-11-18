using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelBotPlayer : MonoBehaviour
{

    [SerializeField] float jumpSpeed = 5.0f;


    Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
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
