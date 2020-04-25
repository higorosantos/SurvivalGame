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
    [SerializeField] private Slider hpBar;
    [SerializeField] private Slider staminaBar;

    private Animator anim;
       
    void Start()
    {
        anim = GetComponent<Animator>();
        playerBase = new PlayerModel();
        playerBase.setName("Higor Oliveira");
        playerBase.setArmor(0);
        nome.text = playerBase.getName();
        hp.text = playerBase.getHp().ToString();
        //hpBar.maxValue = 100f;
        hpBar.value = playerBase.getHp();
        staminaBar.value = playerBase.getStamina();
        

    }
    private void Update()
    {
        if(anim.GetBool("Run") == true)
        {
          this.playerBase.setStamina(this.playerBase.getStamina() - 1);
        }
        Debug.Log(playerBase.getStamina());
    }
    private void OnTriggerEnter(Collider obj)
    {
       //Destroy(obj.gameObject);
        playerBase.Damage(25);
        hp.text = playerBase.getHp().ToString();
        hpBar.value = playerBase.getHp();

    }
    private void lossStamina()
    {
        this.playerBase.setStamina(this.playerBase.getStamina() - 1);
    }
}
