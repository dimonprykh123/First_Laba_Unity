using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputController 
{
    private ServiceManager _serviceManager;
    private Camera _cam;
    private bool _leftPointerClicked;

    public Action<Vector3, Collider> LeftPoinrecClickHandler = delegate { };

    public InputController(ServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
        _cam = Camera.main;
        Time.timeScale = 1;
        _serviceManager = ServiceManager.Instance;
        _serviceManager.UpdateHandler += OnUpdate;
        _serviceManager.LateUpdateHandler += OnLateUpdate;
        _serviceManager.FixedUpdateHandler += OnFixedUpdate;
        _serviceManager.DestroyHandler += OnDestroy;
    }
    void OnUpdate()
    { 
        _leftPointerClicked = Input.GetButton("Fire1");
        Debug.Log("Update");

    }

    private void OnLateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    private void OnFixedUpdate()
    {
        if (_leftPointerClicked)
        {
            RaycastHit hitInfo;
            if (Physics.Raycast(_cam.ScreenPointToRay(Input.mousePosition), out hitInfo, 100))
            {
                LeftPoinrecClickHandler(hitInfo.point, hitInfo.collider);
            }

        }
        Debug.Log("FixedUpdate");
    }

    private void OnDestroy() 
    {
        _serviceManager.UpdateHandler -= OnUpdate;
        _serviceManager.LateUpdateHandler -= OnLateUpdate;
        _serviceManager.FixedUpdateHandler -= OnFixedUpdate;
        _serviceManager.DestroyHandler -= OnDestroy;
    }
}
