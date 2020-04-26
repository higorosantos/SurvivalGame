using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camManager : MonoBehaviour
{
    //Sensibilidade
    public float sensibilidade = 10;
    //Variaveis para guarda posição do Target e do jogador
    public Transform Target, Player;
    private float mouseX, mouseY;
    //Um boolean para verificar se o jogador esta parado ou não
    private bool walking = false;
    //Classe responsavel pelos inputs
    private InputManager inputManager;
    //Distancia entre a camera e o jogador
    private float camDistance = 3;
    //Tempo do Vector3.SmoothDamp
    private float smoothTime = 0.2f;
    //Velociade da suavização do Vector3.SmoothDamp
    private Vector3 smoothVelocity;
    //Rotação Atual usado para ajudar no Vector3.SmoothDamp
    private Vector3 currentRotation;
    



    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        inputManager = GetComponent<InputManager>();
        
    }
    private void Update()
    {
        
    }

    void LateUpdate()
    {
          
        camMov();
        walkingDetected();
        cameraCollision();
        


    }
    void camMov()
    {

       
        mouseX += Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        mouseY -= Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;


        //faz a variavel mouse Y ficar no valor de -35 ate 60
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        
        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(mouseY, mouseX), ref smoothVelocity, smoothTime);
        transform.eulerAngles = currentRotation;
        

        //transform.LookAt(Target);
        //quarternion.euler gira em um certo grau ex: Quarternion.Euler(0,30,0) vai girar 30 graus no eixo Y


        if (walking == true)
        {
            Player.rotation = Quaternion.Euler(0, mouseX, 0);
        }

        transform.position = Target.position - transform.forward * camDistance;
    }
    void walkingDetected()
    {
        if (this.inputManager.getHorizontal() == 0 && this.inputManager.getVertical() == 0)
        {
            this.walking = false;
            Debug.Log("tamo aqui porra");
        }
        else
        {
            this.walking = true;
        }
    }
    void cameraCollision()
    {
        RaycastHit hit;
        if (Physics.Linecast(Target.position,transform.position, out hit))
        {
            Debug.DrawLine(transform.position, hit.point, Color.blue);
            if (hit.transform.gameObject.tag == "Player")
            {
                
                Debug.Log("raycast porra");
                Debug.DrawLine(transform.position, hit.point,Color.red);
                transform.position = hit.point + transform.forward * 0.1f;
               
            }
        }
        else
        {
            Debug.Log("Enconsto em porra nenhuma");
        }
        
    }
   
}
