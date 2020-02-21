using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 5;
    private Rigidbody _rigidbodyZombie;
    private Animator _animatorZombie;

    void Start()
    {
        _rigidbodyZombie = GetComponent<Rigidbody>();
        _animatorZombie = GetComponent<Animator>();
        Jogador = GameObject.FindWithTag("Player").gameObject;
        var tipoZombie = Random.Range(1, 28);
        transform.GetChild(tipoZombie).gameObject.SetActive(true);
    }

    void FixedUpdate()
    {
        var distancia = Vector3.Distance(Jogador.transform.position, transform.position);

        var direcao = Jogador.transform.position - transform.position;
        var novaRotacao = Quaternion.LookRotation(direcao);
        _rigidbodyZombie.MoveRotation(novaRotacao);

        if (distancia > 2.3)
        {
            _rigidbodyZombie
                .MovePosition(_rigidbodyZombie.position + direcao.normalized * Velocidade * Time.deltaTime);
            _animatorZombie.SetBool("Atacando", false);
        }
        else
        {
            _animatorZombie.SetBool("Atacando", true);
        }
    }

    void AoAtacarJogador()
    {
        Time.timeScale = 0;
        Jogador.GetComponent<JogadorController>().TextoGameOver.SetActive(true);
        Jogador.GetComponent<JogadorController>().Vivo = false;
    }
}