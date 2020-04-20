using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movManager : MonoBehaviour
{
    private InputManager inputManager;
    private CharacterController ch;
    private float speed = 6f;
    private float gravity = -19f;
    Vector3 velocity;
    private Animator anim;
    

    void Start()
    {
        inputManager = GetComponent<InputManager>();
        ch = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Gravity();
        Commands();
        UpdateAnimation();
        
    }
    void MovePlayer()
    {
        Vector3 move = new Vector3(inputManager.getSideway(), 0f, inputManager.getForward());
        ch.Move(transform.TransformDirection(move * speed * Time.deltaTime));
       
    }
  
    void Gravity()
    {
        if (!ch.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
            ch.Move(velocity * Time.deltaTime);
        }
        if(ch.isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }
       
    }
    void Commands()
    {
        if(Input.GetButtonDown("Jump") && ch.isGrounded)
        {
            velocity.y = Mathf.Sqrt(3 * -2 * gravity);
        }
    }
    void UpdateAnimation()
    {

        //anim.SetFloat("sideway",inputManager.getSideway());
        //anim.SetFloat("forward",inputManager.getForward());
       
    }
}
