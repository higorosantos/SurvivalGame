using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public ParticleSystem muzzleflash;
    public float damege = 10f;
    public float range = 100f;
    public GameObject teste;

    public GameObject TargetArma;
    // Update is called once per frame

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            muzzleflash.Emit(1);
            
        }
    }
    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(TargetArma.transform.position, TargetArma.transform.forward, out hit, range))
        {
            Debug.DrawLine(transform.position, hit.point);
            Debug.Log(hit.transform.name);
            Instantiate(teste,hit.point,Quaternion.Euler(hit.normal));
          Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.Takedamage(damege);
            }
        }
       
    }
    
}
