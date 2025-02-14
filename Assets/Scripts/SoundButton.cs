using System;
using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class SoundButton : MonoBehaviour
{
    private AudioSource _audioSource;
    
    public event Action<AudioSource> IsClicked;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PressedButtons()
    {
        IsClicked?.Invoke(_audioSource);
    }
}
