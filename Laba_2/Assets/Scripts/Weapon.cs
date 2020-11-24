using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
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
        // Завдаємо змін функціоналу 
    }
    // При натисканні деяких кнопок може відбуватись дія  DestroyItem()  ChangeItemCount() Wearing()

    protected override void Wearing()
    {
        base.Wearing();
    }
    protected override void TakeDamage()
    {
        base.TakeDamage();
    }


}
