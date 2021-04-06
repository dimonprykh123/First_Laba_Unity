using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : LivingCreatureActionController
{
    private PlayerCreature _playerCreature;
    private Interacteble _lastTarget;
    public PlayerActionController(PlayerCreature player) : base(player) 
    {
        _playerCreature = player;
        _playerCreature.ServiceManager.inputController.LeftPoinrecClickHandler += OnLeftPointerCliked;

    }

    private void OnLeftPointerCliked(Vector3 destenation, Collider collider)
    {

        if (collider) {
        }
        if (_lastTarget != null)
        {
            _lastTarget.OnUnfocus();
        }

        if (collider != null) 
        {
            _lastTarget = collider.GetComponent<Interacteble>();
            if (_lastTarget != null)
            {
                _lastTarget.OnFocus(_playerCreature);
                Mouve(_lastTarget.transform.position, _lastTarget.StopingDIstance);
                return;
            }
        }
           

        Mouve(destenation);
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
        _playerCreature.ServiceManager.inputController.LeftPoinrecClickHandler -= OnLeftPointerCliked;
    }
}
