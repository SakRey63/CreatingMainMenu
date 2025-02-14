using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    [SerializeField] private Image _image;

    public void ChangeIconColor(bool click)
    {
        if (click == false)
        {
            _image.color = Color.red;
        }
        else
        {
            _image.color = Color.white;
        }
    }
}
