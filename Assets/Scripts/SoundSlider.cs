using UnityEngine;

public class SoundSlider : MonoBehaviour
{
    [SerializeField] private SoundControl _soundControl;
    
    public void ChangeVolume(float value)
    {
        string name = gameObject.name;
        
        _soundControl.ChangeVolume(name, value);
    }
}
