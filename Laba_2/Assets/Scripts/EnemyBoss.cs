using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : Enemy
{

    protected override void FixedUpdate()
    {
        if (RangeToInteratc(range) && !InFight && !InFalling)
        {
            // Якщо true викликає діалогове вікно 
            // inFight(чив бою гравець) inFalling(Чи падає гравець) методи плеєр контроллера які повертаю true or false 
        }
    }

    protected override void ConfirmInteract()
    {
        InInteract();
    }
    protected override void DeclineInteract()
    {
        OutInteract();
    }

    protected override void OnDeath()
    {
        base.OnDeath();
        ConfirmInteract();// для програвення сцени вбивства босса 
        // Викликає метод DropItem(random) класу Item 

    }
    protected override void Anger()
    {
        base.Anger();
        // Зміна поведінки
    }

    protected override void Calm()
    {
        base.Calm();
        //Зміна поведінки
    }

}
