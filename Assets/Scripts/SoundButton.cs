using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class SoundButton : MonoBehaviour
{
    [SerializeField] private SoundControl _soundControl;
    
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PressedButtons()
    {
        _soundControl.PressedButtonMenu(_audioSource);
    }
}
