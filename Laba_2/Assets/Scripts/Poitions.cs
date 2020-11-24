using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poitions : Item
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
    // При натисканні деяких кнопок може відбуватись дія  DestroyItem()  ChangeItemCount() UsePoition() 
    private void UsePoition() 
    {
        // Має оператор switch який перевіряє назву зілля та викликає методи у плеер контроллера setBuff() RestoreHP() RestoreMP()
    }

    protected override void TakeDamage()
    {
        base.TakeDamage();
    }

}
