using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource _audioSource;
    private static AudioSource _sharedAudioSource;
    
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _sharedAudioSource = _audioSource;
    }
}
