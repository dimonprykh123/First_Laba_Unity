using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LvlButtonController : MonoBehaviour
{
    private Button _button;
    [SerializeField] private Scenes scene;

    private void Start() 
    {
        _button = GetComponent<Button>();
        if (!PlayerPrefs.HasKey(GamePrefs.lvlPlayed.ToString() + ((int)scene).ToString()))
        {
            _button.interactable = false;
            return;
        }
        _button.onClick.AddListener(ChangeLvl);
        GetComponentInChildren<TMP_Text>().text = ((int)scene).ToString();
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveAllListeners();
    }
    private void ChangeLvl() 
    {
        ServiceManager.Instanse.ChangeLvl((int)scene);
    }
}
