using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    public JogadorController JogadorController;

    public Slider SliderVidaJogador;

    // Start is called before the first frame update
    void Start()
    {
        SliderVidaJogador.maxValue = JogadorController.Vida;
        AtualizarSliderVida();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AtualizarSliderVida()
    {
        SliderVidaJogador.value = JogadorController.Vida;
    }
}