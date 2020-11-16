using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditorInternal;

[RequireComponent(typeof(Mouvment_controller))]
public class InputConroll : MonoBehaviour
{
    Mouvment_controller _playerMouvment;
    DateTime _strikeClickTime;
    float _mouve;
    bool _jump;
    bool _crowling;
    bool _canAtack;    
    private void Start()
    {
        _playerMouvment = GetComponent<Mouvment_controller>();
    }
    void Update()
    {
        _mouve = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonUp("Jump"))
        {
            _jump = true;
        }
        _crowling = Input.GetKey(KeyCode.C);
        if (Input.GetKey(KeyCode.E))
            _playerMouvment.StartCasting();
        if (Input.GetButtonDown("Fire1")) {
            _strikeClickTime = DateTime.Now;
            _canAtack = true;
        } 
        if (Input.GetButtonUp("Fire1"))
        {
            float holdTime = (float)(DateTime.Now - _strikeClickTime).TotalSeconds;
            if(_canAtack)
                _playerMouvment.StartStrike(holdTime);
            _canAtack = false;    
        }
        if ((DateTime.Now - _strikeClickTime).TotalSeconds >= _playerMouvment.ChargeTime*2 && _canAtack) {
            _playerMouvment.StartStrike(_playerMouvment.ChargeTime);
            _canAtack = false;
        }
    }
    private void FixedUpdate()
    {
        _playerMouvment.Move(_mouve, _jump, _crowling);
        _jump = false;
    }
}
