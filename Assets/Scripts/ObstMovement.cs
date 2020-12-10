using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstMovement : MonoBehaviour
{
    [SerializeField] float xSpeed = 1.5f;
    Rigidbody Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(IsMovingRight()){
            Rb.velocity = new Vector3(xSpeed, 0f, 0f);
        }else{
            Rb.velocity = new Vector3(-xSpeed, 0f, 0f); 
        }
        
    }

    private bool IsMovingRight()
    {
        return transform.localScale.x > 0;   
    }

    private void OnTriggerExit(Collider collision)
    {
        transform.localScale = new Vector3(-(Mathf.Sign(Rb.velocity.x)), 2.65f);
    }
    
}
