using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;
public class Move : MonoBehaviour
{   CharacterController player;

    ////Player controle
    public float speedPlayer;
    public float horizontalMove;
    public float verticalMove;
    private Vector3 playerInput;
    public float jumpForce = 3f;
    ////
    private Animator anime;
    private InputManager inputManager;
    private PlayerModel playeer;
    ////Gravidade
    private Vector3 velocity;
    public float gravity = -9.8f;
    ////
    void Start()
    {
        player = GetComponent<CharacterController>();
        anime = GetComponent<Animator>();
        inputManager = GetComponent<InputManager>();
        playeer = new PlayerModel();
        playeer.setName("Higor Oliveira");
        Debug.Log(playeer.getName());
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Gravity();
        SkillsPlayer();
        
        
        
    }

    private void MovePlayer(){
        //horizontalMove = Input.GetAxis("Horizontal");
        //verticalMove = Input.GetAxis("Vertical") ;
        
        
        playerInput = Vector3.ClampMagnitude(playerInput,1);
        playerInput = new Vector3(inputManager.getHorizontal(), 0f, inputManager.getVertical());
        
        
        
        anime.SetFloat("Horizontal", inputManager.getHorizontal());
        anime.SetFloat("Vertical", inputManager.getVertical());

        player.Move(transform.TransformDirection(playerInput)* speedPlayer * Time.deltaTime);


    }
    private void Gravity(){

        if(!player.isGrounded){
            velocity.y += gravity * Time.deltaTime;
            player.Move(velocity * Time.deltaTime);
        }
        if(player.isGrounded && velocity.y < 0f){
            velocity.y = 0f;
        }
        

    }
    private void SkillsPlayer(){
        if(Input.GetButtonDown("Jump") && player.isGrounded){
            velocity.y = Mathf.Sqrt(jumpForce * -2 * gravity);
        }
    }
    
    
}
