using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ServiceManager : MonoBehaviour
{
    public static ServiceManager Instance;

    public InputController inputController{ get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }
    public bool Paused { get; private set; }
    public Action UpdateHandler = delegate { };
    public Action LateUpdateHandler = delegate { };
    public Action FixedUpdateHandler = delegate { };
    public Action DestroyHandler = delegate { };

    private void Start()
    {
        inputController = new InputController(this);
    }
    public void Pause()
    {
        Paused = true;
        Time.timeScale = 0;
    }

    public void Unpause()
    {
        Paused = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && Paused)
        {
            Unpause();
        }
        else if (Input.GetKeyUp(KeyCode.Space) && !Paused)
        {
            Pause();
        }

        if (Paused)
            return;

        UpdateHandler();  
    }
    private void LateUpdate()
    {
        if (Paused)
            return;

        LateUpdateHandler();
    }

    private void FixedUpdate()
    {
        if (Paused)
            return;
        FixedUpdateHandler();
    }

    private void OnDestroy() { 
    }
}
