using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JogadorController : MonoBehaviour
{
    public float Velocidade = 10;
    private Vector3 _direcao;
    public LayerMask MascaraChao;
    public GameObject TextoGameOver;
    public bool Vivo = true;
    private Animator _animatorJogador;
    private Rigidbody _rigidbodyJogador;
    
    // Start is called before the first frame update
    void Start()
    {
        _animatorJogador = GetComponent<Animator>();
        _rigidbodyJogador = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var eixoX = Input.GetAxis("Horizontal");
        var eixoY = Input.GetAxis("Vertical");
        _direcao = new Vector3(eixoX, 0, eixoY);
     
        _animatorJogador.SetBool("EstaCorrendo", _direcao != Vector3.zero);

        if (Vivo || !Input.GetButtonDown("Fire1"))
        {
            return;
        }
        
        SceneManager.LoadScene("ApocalipseZombie");
        Time.timeScale = 1;
    }

    private void FixedUpdate()
    {
        _rigidbodyJogador.MovePosition(_rigidbodyJogador.position + _direcao.normalized * Velocidade * Time.deltaTime);

        var raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * 50, Color.red);

        if (!Physics.Raycast(raio, out var impacto, 100, MascaraChao))
        {
            return;
        }
        
        var posicaoMiraJogador = impacto.point - transform.position;
        posicaoMiraJogador.y = transform.position.y;

        var novaRotacao = Quaternion.LookRotation(posicaoMiraJogador);
            
        _rigidbodyJogador.MoveRotation(novaRotacao);
    }
}
