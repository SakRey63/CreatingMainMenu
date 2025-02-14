using UnityEngine;
using UnityEngine.Audio;

public class SoundControl : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    
    private float _minVolume = -80;
    private float _maxVolume = 0;

    public void ClickedButtonMasterMusic(string name, bool isClick)
    {
        if (isClick == false)
        {
            _mixer.audioMixer.SetFloat(name, _minVolume);
        }
        else
        {
            _mixer.audioMixer.SetFloat(name, _maxVolume);
        }
    }
    
    public void ChangeVolume(string name, float volume)
    {
        _mixer.audioMixer.SetFloat(name, Mathf.Lerp(_minVolume, _maxVolume, volume));
    }

    public void PressedButtonMenu(AudioSource audio)
    {
        audio.Play();
    }
}