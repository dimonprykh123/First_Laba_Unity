using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultEnemy :Enemy
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void Anger()
    {
        base.Anger();
        // Зміна поведінки
    }

    protected override void Calm()
    {
        base.Calm();
        // Зміна поведінки
    }

    protected override void InInteract()
    {
        base.InInteract();
    }
    protected override void DeclineInteract()
    {
        base.DeclineInteract();
    }

    protected override void OnDeath()
    {
        base.OnDeath();
        // Виклик методу  ChangeGold(int gold) 
    }
}
