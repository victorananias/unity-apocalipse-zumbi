using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject Bala;
    
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bala, transform.position, transform.rotation);
        }
    }
}
