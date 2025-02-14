using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    private const string MasterVolume = "MasterVolume";
    
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private BackgroundVolume _background;
    [SerializeField] private MasterVolume _master;
    [SerializeField] private UiVolume _ui;
    [SerializeField] private MuteButton _mute;

    private bool _isClick = false;
    private float _minVolume = -80;
    private float _maxVolume = 0;

    private void OnEnable()
    {
        _background.IsSwiped += ChangeVolume;
        _master.IsSwiped += ChangeVolume;
        _ui.IsSwiped += ChangeVolume;
    }

    private void OnDisable()
    {
        _background.IsSwiped -= ChangeVolume;
        _master.IsSwiped -= ChangeVolume;
        _ui.IsSwiped -= ChangeVolume;
    }

    public void ClickedButtonMasterMusic()
    {
        if (_isClick == false)
        {
            _mixer.audioMixer.SetFloat(MasterVolume, _minVolume);
            
            _mute.ChangeIconColor(_isClick);
            
            _isClick = true;
        }
        else
        {
            _mixer.audioMixer.SetFloat(MasterVolume, _maxVolume);
            
            _mute.ChangeIconColor(_isClick);

            _isClick = false;
        }
    }
    
    private void ChangeVolume(string name, float volume)
    {
        _mixer.audioMixer.SetFloat(name, Mathf.Lerp(_minVolume, _maxVolume, volume));
    }
}