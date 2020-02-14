using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject Bala;
    public GameObject CanoArma;
    
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bala, CanoArma.transform.position, CanoArma.transform.rotation);
        }
    }
}
