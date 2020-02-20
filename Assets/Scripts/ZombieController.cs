using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 5;
    void Start()
    {
        Jogador = GameObject.FindWithTag("Player").gameObject;
        var tipoZombie = Random.Range(1, 28);
        transform.GetChild(tipoZombie).gameObject.SetActive(true);
    }

    void FixedUpdate()
    {
        var distancia = Vector3.Distance(Jogador.transform.position, transform.position);

        var direcao = Jogador.transform.position - transform.position;
        var novaRotacao = Quaternion.LookRotation(direcao);
        GetComponent<Rigidbody>().MoveRotation(novaRotacao);

        if (distancia > 2.3)
        {
            GetComponent<Rigidbody>()
                .MovePosition(GetComponent<Rigidbody>().position + direcao.normalized * Velocidade * Time.deltaTime);
            GetComponent<Animator>().SetBool("Atacando", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("Atacando", true);
        }
    }

    void AoAtacarJogador()
    {
        Time.timeScale = 0;
        Jogador.GetComponent<JogadorController>().TextoGameOver.SetActive(true);
        Jogador.GetComponent<JogadorController>().Vivo = false;
    }
}