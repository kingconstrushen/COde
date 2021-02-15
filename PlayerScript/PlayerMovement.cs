using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 5f;
    public float sprint = 2f;
    public float gravity = -9.81f;
    public float jumpHeight = 1f;

    public Transform groundCheck;
    public float groundDistance = 0.48f;
    public LayerMask groundMask;

    public Vector3 velocity;
    public static bool isGrounded;

    public bool noClip;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * sprint;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        // TO DO IN THE FUTUR
        //if(Input.GetKeyDown("v") && noClip == false) {
        //    gravity = 0;
        //    noClip = true;
        //}
        //else if (Input.GetKeyDown("v") && noClip == true) {
        //    gravity = -9.81f;
        //    noClip = false;
        //}
    }
}
