using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class MainView : MonoBehaviour
{
    public Button settingBtn;
    public Button playBtn;
    public Button pauseBtn;
    public Button customizeBtn;

    public TextMeshProUGUI moneyText;

    private void Start()
    {
        RefreshButton();
        InitButton();
    }

    private void OnDestroy()
    {
        RefreshButton();
    }

    private void InitButton()
    {
        settingBtn.onClick.AddListener(MainEventManager.instance.OnSettingBtnClicked);
        playBtn.onClick.AddListener(MainEventManager.instance.OnPlayBtnClicked);
        pauseBtn.onClick.AddListener(MainEventManager.instance.OnPauseBtnClicked);
        customizeBtn.onClick.AddListener(MainEventManager.instance.OnCustomizeBtnClicked);
    }

    private void RefreshButton()
    {
        settingBtn.onClick.RemoveAllListeners();
        playBtn.onClick.RemoveAllListeners();
        pauseBtn.onClick.RemoveAllListeners();
        customizeBtn.onClick.RemoveAllListeners();
    }
}
