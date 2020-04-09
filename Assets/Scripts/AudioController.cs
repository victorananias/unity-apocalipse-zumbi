using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource _audioSource;
    public static AudioSource SharedAudioSource;
    
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        SharedAudioSource = _audioSource;
    }
}
