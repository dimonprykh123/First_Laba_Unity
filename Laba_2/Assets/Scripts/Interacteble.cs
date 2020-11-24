using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Interacteble : MonoBehaviour
{
    // Всі підписки на слухачі івентів відбулись тута!
    // Створення єкземплярів також тута !
    protected virtual void FixedUpdate()
    {
        if (RangeToInteratc(range) && !InFight && !InFalling)
        {
            // Якщо true викликає діалогове вікно 
            // inFight(чив бою гравець) inFalling(Чи падає гравець) методи плеєр контроллера які повертаю true or false 
        }
    }

    protected virtual void ConfirmInteract() 
    {
        InInteract();
    // Перехід до меню інтерактиву  
    // Надалі цей метод зазначений за певним івентом 
    }

    protected virtual void DeclineInteract() 
    {
        OutInteract();
        // Закриття діалогового вікна 
        // Надалі цей метод зазначений за певним івентом 
    }
    protected  bool RangeToInteratc(float range)
    {
        // Приймає відстань до цілі з якою буде взаємодіяти якщо звдовілнив умову то спливає підказка на (підняття прдмету, початок діалогу , виконання певної дії)
        return _someBool;
    }

    protected virtual void InInteract() 
    { 
        //Виключає деякий функціонал та надає інший 
    }

    protected  virtual void OutInteract() 
    { 
    // Повертає стандартний функціонал
    }
}
   

   

