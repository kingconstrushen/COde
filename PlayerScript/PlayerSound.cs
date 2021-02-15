using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    CharacterController cc;
    public bool isGroundedSound;

        
    
        void Start()
    {
        cc = GetComponent<CharacterController>();
       PlayerMovement.isGrounded = isGroundedSound; 
    }


    void Update()
    {



        if (isGroundedSound == true && GetComponent<AudioSource>().isPlaying == false)
		{
            GetComponent<AudioSource>().volume = Random.Range(0.8f, 1);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
            GetComponent<AudioSource>().Play();

        }

    }
}
