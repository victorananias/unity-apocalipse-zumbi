using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZombies : MonoBehaviour
{
    public GameObject Zombie;
    public float TempoGerarZombie = 1;
    private float ContadorTempo = 0;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ContadorTempo += Time.deltaTime;
        if (TempoGerarZombie > ContadorTempo)
        {
            return;
        }
        
        Instantiate(Zombie, transform.position, transform.rotation);
        ContadorTempo = 0;
    }
}
