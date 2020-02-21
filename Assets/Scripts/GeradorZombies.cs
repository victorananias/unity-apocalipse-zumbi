using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZombies : MonoBehaviour
{
    public GameObject Zombie;
    public float TempoGerarZombie = 1;
    private float _contadorTempo = 0;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _contadorTempo += Time.deltaTime;
        if (TempoGerarZombie > _contadorTempo)
        {
            return;
        }
        
        Instantiate(Zombie, transform.position, transform.rotation);
        _contadorTempo = 0;
    }
}
