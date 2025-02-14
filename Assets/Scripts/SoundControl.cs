using UnityEngine;
using UnityEngine.Audio;

public class SoundControl : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private SoundSlider _masterSound;
    [SerializeField] private SoundSlider _uiSound;
    [SerializeField] private SoundSlider _musicSound;
    [SerializeField] private SoundButton _play;
    [SerializeField] private SoundButton _authors;
    [SerializeField] private SoundButton _exit;

    private bool _isClick = false;
    private float _minVolume = -80;
    private float _maxVolume = 0;

    private void OnEnable()
    {
        _play.IsClicked += PressedButtonMenu;
        _authors.IsClicked += PressedButtonMenu;
        _exit.IsClicked += PressedButtonMenu;
        _masterSound.IsSwiped += ChangeVolume;
        _uiSound.IsSwiped += ChangeVolume;
        _musicSound.IsSwiped += ChangeVolume;
    }

    private void OnDisable()
    {
        _play.IsClicked -= PressedButtonMenu;
        _authors.IsClicked -= PressedButtonMenu;
        _exit.IsClicked -= PressedButtonMenu;
        _masterSound.IsSwiped -= ChangeVolume;
        _uiSound.IsSwiped -= ChangeVolume;
        _musicSound.IsSwiped -= ChangeVolume;
    }

    public void ClickedButtonMasterMusic(string name, bool click)
    {
        if (click == false)
        {
            _mixer.audioMixer.SetFloat(name, _minVolume);
        }
        else
        {
            _mixer.audioMixer.SetFloat(name, _maxVolume);
        }
    }
    
    private void ChangeVolume(string name, float volume)
    {
        _mixer.audioMixer.SetFloat(name, Mathf.Lerp(_minVolume, _maxVolume, volume));
    }

    private void PressedButtonMenu(AudioSource _audio)
    {
        _audio.Play();
    }
}