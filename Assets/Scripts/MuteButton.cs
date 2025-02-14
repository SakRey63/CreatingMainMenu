using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    [SerializeField] private Image _image;
    
    private bool _onClick = false;

    public void ChangeIconColor()
    {
        if (_onClick == false)
        {
            _image.color = Color.red;
            
            _onClick = true;
        }
        else
        {
            _image.color = Color.white;

            _onClick = false;
        }
    }
}
