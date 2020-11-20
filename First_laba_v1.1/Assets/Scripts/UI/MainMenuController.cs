using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : BaseGameMenuController
{
    [SerializeField] private Button _chooseLvl;
    [SerializeField] private Button _reset;
    [SerializeField] private Button _closeLvlMenu;
    [SerializeField] private GameObject _lvlMenu;
    int lvl = 1;
    protected override void Start()
    {
        base.Start();
        _chooseLvl.onClick.AddListener(UseLvlMenu);
        _closeLvlMenu.onClick.AddListener(UseLvlMenu);
        _reset.onClick.AddListener(_serviceManager.ResetProgress);
        if (PlayerPrefs.HasKey(GamePrefs.lastPlayedLvl.ToString()))
        {
            _play.GetComponentInChildren<TMP_Text>().text = "Resume";
            lvl = PlayerPrefs.GetInt(GamePrefs.lastPlayedLvl.ToString());
        }
        _play.onClick.AddListener(Play);
        _reset.onClick.AddListener(OnResetClicked); 

    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
        _chooseLvl.onClick.RemoveListener(UseLvlMenu);
        _closeLvlMenu.onClick.RemoveListener(UseLvlMenu);
        _reset.onClick.RemoveListener(_serviceManager.ResetProgress);
        _play.onClick.RemoveListener(Play);
    }

    private void UseLvlMenu() 
    {
        _lvlMenu.SetActive(!_lvlMenu.activeInHierarchy);
        UseGameMenu();
    }

    private void Play() 
    {
        _serviceManager.ChangeLvl(lvl);
    }

    private void OnResetClicked() 
    {
        _play.GetComponentInChildren<TMP_Text>().text = "Play";
        _serviceManager.ResetProgress();
    }
}
