using System;
using UnityEngine;
public class MainEventManager : MonoBehaviour
{
    public static MainEventManager instance { get; private set; }

    public event Action OnPlayClicked;
    public event Action OnPauseClicked;
    public event Action OnSettingClicked;
    public event Action OnCustomizeClicked;

    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }
    
    public void OnPlayBtnClicked() => OnPlayClicked?.Invoke();
    
    public void OnPauseBtnClicked() => OnPauseClicked?.Invoke();
    
    public void OnSettingBtnClicked() => OnSettingClicked?.Invoke();
    
    public void OnCustomizeBtnClicked() => OnCustomizeClicked?.Invoke();
}