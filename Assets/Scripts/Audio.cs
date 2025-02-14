using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    private const string BackgroundVolume = "BackgroundVolume";
    private const string UiVolume = "UiVolume";
    private const string MasterVolume = "MasterVolume";
    
    [SerializeField] private AudioMixerGroup _mixer;

    private bool _onClick = false;
    private float _minVolume = -80;
    private float _maxVolume = 0;

    public void ChangeMasterVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(MasterVolume, Mathf.Lerp(_minVolume, _maxVolume, volume));
    }
    
    public void ChangeUiVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(UiVolume, Mathf.Lerp(_minVolume, _maxVolume, volume));
    }
    
    public void ChangeBackgroundVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(BackgroundVolume, Mathf.Lerp(_minVolume, _maxVolume, volume));
    }

    public void ButtonMasterMusic()
    {
        if (_onClick == false)
        {
            _mixer.audioMixer.SetFloat(MasterVolume, _minVolume);
            
            _onClick = true;
        }
        else
        {
            _mixer.audioMixer.SetFloat(MasterVolume, _maxVolume);

            _onClick = false;
        }
    }
}
