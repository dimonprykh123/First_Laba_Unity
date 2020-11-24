using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryNPC : MainNPC
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

    protected override void NextDialogScene()
    {
        base.NextDialogScene();
    }

    protected override void EndDialog()
    {
        base.EndDialog();
      
    }

    protected virtual void TakeQuest()
    {
        // Викликає метод інстенсу завдань (AddToSecondaryQuests(string NameOfQuest))
    }
  
}
