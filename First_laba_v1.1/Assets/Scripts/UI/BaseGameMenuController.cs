using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseGameMenuController : MonoBehaviour
{
    protected ServiceManager _serviceManager;

    [SerializeField] protected GameObject _menu;
    [SerializeField] protected Button _play;
    [SerializeField] protected Button _quit;
    [SerializeField] protected Button _settings;

    protected virtual void Start()
    {
        _serviceManager = ServiceManager.Instanse;
        
        _quit.onClick.AddListener(_serviceManager.Quit);
    }

    protected virtual void OnDestroy()
    {
        
        _quit.onClick.RemoveListener(_serviceManager.Quit);
    }

    protected virtual void Update()
    {
    }

    protected virtual void UseGameMenu()
    {
        _menu.SetActive(!_menu.activeInHierarchy);
    }
}
