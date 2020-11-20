using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameMenuController : BaseGameMenuController
{
    [SerializeField] private Button _restart;
    [SerializeField] private Button _backToMenu;

    protected override void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) {
            UseGameMenu();
        }
    }
    protected override void Start()
    {
        base.Start();
        _restart.onClick.AddListener(_serviceManager.Restart);
        _play.onClick.AddListener(UseGameMenu);
        _backToMenu.onClick.AddListener(GoToMainMenu);
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
        _restart.onClick.RemoveListener(_serviceManager.Restart);
        _play.onClick.RemoveListener(UseGameMenu); 
        _backToMenu.onClick.RemoveListener(GoToMainMenu);
    }
    protected override void UseGameMenu() 
    {
        base.UseGameMenu();
        Time.timeScale = _menu.activeInHierarchy ? 0 : 1 ;

    }

    public void GoToMainMenu()
    {
        ServiceManager.Instanse.ChangeLvl((int)Scenes.MainMenu);
    }
}
