using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    public float Velocidade = 20;
    private Rigidbody _rigidbodyBala;

    private void Start()
    {
        _rigidbodyBala = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbodyBala.MovePosition(_rigidbodyBala.position + transform.forward * Velocidade * Time.deltaTime);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Inimigo"))
        {
            Destroy(other.gameObject);
        }
        
        Destroy(gameObject);
    }
}
