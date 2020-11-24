using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Interacteble
{
    // Всі підписки на слухачі івентів відбулись тута!
    // Створення єкземплярів також тута !
    protected override void FixedUpdate()
    {
        if (RangeToInteratc(range) && !InFalling)
        {
            InInteract();
            // inFight(чив бою гравець) inFalling(Чи падає гравець) методи плеєр контроллера які повертаю true or false
        }
        else {
            OutInteract();
        }
    }

    protected override void InInteract()
    {
        base.InInteract();
        // Додаємо нову поведінку якщо потрібно
        Anger();
    }

    protected override void OutInteract()
    {
        base.OutInteract();
        // Додаємо нову поведніку якщо потрібно
        Calm();
    }
    protected virtual void OnDeath()
    {
       
    // Знищуємо ігровий об'єкт та дає досвід гловному герою через інстанс Плеер контроллера GainExp(int val)
    }

    protected virtual void Anger()
    { 
    // Ворог атакує нас та біжить до нас використовує здібності або супер удари 'так я це про інтерактив не буду розписувати те що було в 2D BaseController'
    }

    protected virtual void Calm() 
    { 
    // Ворог входить до стану спокою 
    }

}
