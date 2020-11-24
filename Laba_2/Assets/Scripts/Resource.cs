using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : Item
{
    // Всі підписки на слухачі івентів відбулись тута!
    // Створення єкземплярів також тута !
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void ConfirmInteract()
    {
        base.ConfirmInteract();
    }

    protected override void DeclineInteract()
    {
        base.DeclineInteract();
    }

    protected override void UpgradeItem()
    {
        base.UpgradeItem();
    }

    protected override void TakeDamage()
    {
        base.TakeDamage();
    }

}
