using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 5;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        var distancia = Vector3.Distance(Jogador.transform.position, transform.position);

        if (!(distancia > 2.3))
        {
            return;
        }
        
        var direcao = Jogador.transform.position - transform.position;
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + direcao.normalized * Velocidade * Time.deltaTime);
        var novaRotacao = Quaternion.LookRotation(direcao);
        GetComponent<Rigidbody>().MoveRotation(novaRotacao);
    }
}
