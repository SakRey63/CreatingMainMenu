using UnityEngine;

public class SoundButton : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PressedButtons()
    {
        _audioSource.Play();
    }
}
