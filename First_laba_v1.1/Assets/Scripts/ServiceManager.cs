using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ServiceManager : MonoBehaviour
{
    public static ServiceManager Instanse;

    private void Start()
    {
        Time.timeScale = 1;
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            PlayerPrefs.SetInt(GamePrefs.lastPlayedLvl.ToString(), SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt(GamePrefs.lvlPlayed.ToString() + SceneManager.GetActiveScene().buildIndex, 1);
        }
    }

    private void Awake()
    {
        if (Instanse == null)
            Instanse = this;
        else
            Destroy(gameObject);
    }

    public void ResetProgress()
    {
        PlayerPrefs.DeleteAll();
    }
    public void Restart()
    {
        ChangeLvl(SceneManager.GetActiveScene().buildIndex);
    }

    public void EndLevel()
    {
       ChangeLvl(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ChangeLvl(int idx)
    {
        SceneManager.LoadScene(idx); 
    }

    public void Quit() 
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

public enum Scenes { 
MainMenu,first,second,
}

public enum GamePrefs { 
    lastPlayedLvl,
    lvlPlayed
}