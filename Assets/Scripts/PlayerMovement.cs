﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Velocidade = 10;
    private Vector3 direcao;
    public LayerMask MascaraChao;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var eixoX = Input.GetAxis("Horizontal");
        var eixoY = Input.GetAxis("Vertical");
        direcao = new Vector3(eixoX, 0, eixoY);
     
        GetComponent<Animator>().SetBool("EstaCorrendo", direcao != Vector3.zero);
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + direcao.normalized * Velocidade * Time.deltaTime);

        var raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * 50, Color.red);

        if (!Physics.Raycast(raio, out var impacto, 100, MascaraChao))
        {
            return;
        }
        
        var posicaoMiraJogador = impacto.point - transform.position;
        posicaoMiraJogador.y = transform.position.y;

        var novaRotacao = Quaternion.LookRotation(posicaoMiraJogador);
            
        GetComponent<Rigidbody>().MoveRotation(novaRotacao);
    }
}
