using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interacteble
{
    // Всі підписки на слухачі івентів відбулись тута!
    // Створення єкземплярів також тута !
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
    protected override void InInteract()
    {
        base.InInteract();
        // Додаємо нову поведніку якщо потрібно
    }
    protected override void OutInteract()
    {
        base.OutInteract();
        // Додаємо нову поведніку якщо потрібно 
    }
    protected virtual void NextDialogScene() { 
    // Переводить до наступного розмовного меню 
    }

    protected override void ConfirmInteract()
    {
        base.ConfirmInteract();
        StartDialog();
    }

    protected override void DeclineInteract()
    {
        base.DeclineInteract();
        // Вихід з діалогу 
        EndDialog();
    }
    protected virtual void StartDialog() 
    {
    //Розпочинає діалогову сцену або відео 
    }

    protected virtual void EndDialog() 
    {
        //Розпочинає діалогову сцену або відео
    }

}
