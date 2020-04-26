using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private PlayerModel playerBase;
    [SerializeField]private Text nome;
    [SerializeField]private Text hp;
    [SerializeField]private Slider hpBar;
    [SerializeField]private Slider staminaBar;
    private float timer = 0;
    private bool isRegenStamina,isRegenHp = false;
    private Animator anim;
    private IEnumerator coroutine;
       
    void Start()
    {
        anim = GetComponent<Animator>();
        playerBase = new PlayerModel();
        playerBase.setName("Higor Oliveira");
        //playerBase.setArmor(0);
        nome.text = playerBase.getName();
        hp.text = playerBase.getHp().ToString();
        //hpBar.maxValue = 100f;
        hpBar.value = playerBase.getHp();
        staminaBar.value = playerBase.getStamina();
        

    }
    private void Update()
    {
        lossStamina();
        staminaBar.value = this.playerBase.getStamina();
        hpBar.value = this. playerBase.getHp();
        if (!anim.GetBool("Run") && isRegenStamina == false && this.playerBase.getStamina()< 100)
        {
            StartCoroutine("regenStamina");
            // Debug.Log("ta aqui");
        }
        if(isRegenHp == false && this.playerBase.getHp() < 50)
        {
            coroutine = regenHP();
            StartCoroutine(coroutine);
        }

    }
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Enemy"))
        {
            playerBase.setHp(playerBase.getHp() - 20);
            if(isRegenHp == true)
            {
                StopCoroutine(coroutine);
                isRegenHp = false;
            } 
        }
    }
   

    IEnumerator regenStamina()
    {
        isRegenStamina = true;
        yield return new WaitForSeconds(3.0f);
        while (this.playerBase.getStamina() < 100 && !anim.GetBool("Run")) 
        {
            this.playerBase.setStamina(this.playerBase.getStamina() + 2.5f);
            yield return new WaitForSeconds(1.0f);
            
        }
        isRegenStamina = false;
    }
    IEnumerator regenHP()
    {
        isRegenHp = true;
        yield return new WaitForSeconds(5.0f);
        while (this.playerBase.getHp() < 50)
        {
            this.playerBase.setHp(this.playerBase.getHp() + 2.2f);
            yield return new WaitForSeconds(0.8f);
        }
        isRegenHp = false;
    }

    private void lossStamina()
    {
        if (this.playerBase.getStamina() < 1)
        {
            anim.SetBool("Run", false);
        }


       else if (anim.GetBool("Run") == true)
        {
           

            timer += Time.deltaTime;

            //Debug.Log(timer);
            if (timer > 1f)
            {
                float loss = this.playerBase.getStamina() - 3.5f;
                this.playerBase.setStamina(loss);
                timer = 0.0f;

            }

            
        }
        
    }
}
