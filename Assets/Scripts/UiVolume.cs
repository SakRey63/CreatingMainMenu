using System;
using UnityEngine;

public class UiVolume : MonoBehaviour
{
    public event Action<string, float> IsSwiped;

    public void ChangeVolume(float value)
    {
        string name = gameObject.name;
        
        IsSwiped?.Invoke(name, value);
    }
}
