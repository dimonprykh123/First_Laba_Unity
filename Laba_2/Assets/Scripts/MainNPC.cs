using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainNPC : NPC
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
        TakeQuest();// При першій розмові або першій розмові при виконаному попереддньому квесту
        FinishQuest();// При розмові після отримання квесту та виконаних умовах квесту 
        //та дає досвід гловному герою через інстанс Плеер контроллера GainExp(int val)
    }

    protected virtual void TakeQuest()
    { 
    // Викликає метод інстенсу завдань (AddToPrimaryQuests(string NameOfQuest))
    }
    protected virtual void FinishQuest()
    {
        // Викликається при завершенні квесту 
        TakeRevards();

    }
    protected virtual void TakeRevards()
    {
        // Отримати винагороду
       // Викликає методи із інстенсу айтемів та плеер контоллера (ChangeItemCount(int count, string itemName), ChangeGold(int gold))
    }
}

