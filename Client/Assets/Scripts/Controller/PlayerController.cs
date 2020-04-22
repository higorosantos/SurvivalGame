using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private PlayerModel player;
    [SerializeField]private Text name;
    [SerializeField]private Text hp;
    void Start()
    {
        player = new PlayerModel();
        player.setName("Higor Oliveira");
        player.setArmor(20);
        name.text = player.getName();
        hp.text = player.getHp().ToString();


    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider obj)
    {
       //Destroy(obj.gameObject);
        player.Damage(25);
        hp.text = player.getHp().ToString();

    }
}
