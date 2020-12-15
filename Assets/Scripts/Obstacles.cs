using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Obstacles : MonoBehaviour
{
    PlayerMovementScript playerMovement;

    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovementScript>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player"){
            playerMovement.Die();

        }
    }

    private void Update()
    {

    }
}
