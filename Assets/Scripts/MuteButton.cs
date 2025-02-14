using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    private const string MasterVolume = "MasterVolume";
    
    [SerializeField] private Image _image;
    [SerializeField] private SoundControl _soundControl;

    private bool _isClick = false;
    
    public void ClickButtonMute()
    {
        if (_isClick == false)
        {
            _image.color = Color.red;

            SwitchSound();

            _isClick = true;
        }
        else
        {
            _image.color = Color.white;
            
            SwitchSound();

            _isClick = false;
        }
    }

    private void SwitchSound()
    {
        _soundControl.ClickedButtonMasterMusic(MasterVolume, _isClick);
    }
}
