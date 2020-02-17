using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Jogador;
    private Vector3 _distanciaCompensar; 
    
    // Start is called before the first frame update
    void Start()
    {
        _distanciaCompensar = transform.position - Jogador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Jogador.transform.position + _distanciaCompensar;
    }
}
