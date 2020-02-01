using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var eixoX = Input.GetAxis("Horizontal");
        var eixoY = Input.GetAxis("Vertical");
        
        var direcao = new Vector3(eixoX, 0, eixoY);
        
        transform.Translate(direcao * Time.deltaTime * PlayerSpeed);

        GetComponent<Animator>().SetBool("EstaCorrendo", direcao != Vector3.zero);
    }
}
