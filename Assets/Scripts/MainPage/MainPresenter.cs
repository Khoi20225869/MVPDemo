using UnityEngine;

public class MainPresenter 
{
    private readonly MainView _view;
    public void Init()
    {
        MainEventManager.instance.OnPlayClicked += HandlePlayerClicked;
        MainEventManager.instance.OnPauseClicked += HandlePauseClicked;
        MainEventManager.instance.OnSettingClicked += HandleSettingClicked;
        MainEventManager.instance.OnCustomizeClicked += HandleCustomizeClicked;
    }

    private void HandlePlayerClicked()
    {
        Debug.Log("Player clicked");
    }
    
    private void HandlePauseClicked()
    {
        Debug.Log("Pause clicked");
    }
    
    private void HandleSettingClicked()
    {
        Debug.Log("Setting clicked");
    }

    private void HandleCustomizeClicked()
    {
        TransitionService.CustomizeClicked();
        Debug.Log("Customize clicked");
    }
}
