using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Interacteble 
{
    // Всі підписки на слухачі івентів відбулись тута!
    // Створення єкземплярів також тута !
    protected override void FixedUpdate()
    {
        if (RangeToInteratc(range) && !InFalling)
        {
            // Якщо true викликає діалогове вікно 
            // inFight(чив бою гравець) inFalling(Чи падає гравець) методи плеєр контроллера які повертаю true or false 
        }
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
    protected override void ConfirmInteract()
    {
        ChangeItemCount(count,item);
    }
    protected override void DeclineInteract()
    {
        base.DeclineInteract();
    }
    public void ChangeItemCount(int count, string itemName)
    {
        // Додає айтем до рюкзака
        // Або зменшує кількість айтемів інтерактиву, якщо кількість не вкзаано то 1 одиницю 
    }

    public void DropItem(string name) 
    {
        ChangeItemCount(count,name);
    // Викидає айтем у сцену де зним можна буду взаємодіяти 
    }

    public void DestroyItem(string name, int count = 1)
    {
       // Знищує айтем 
    }

    protected virtual void UpgradeItem() 
    { 
    //Покращує деякі характеристики предметів за певних умов 
    }

    protected virtual void TakeDamage() 
    {
        // При використанні зброї або триманні пошкоджень одежею , або атакою по зіллям там ресурсам завдає їм шкоди коли хп=0 знищує айтем  
        if (itemHp <= 0)
            DestroyItem(gameObject.name, count);
    }

    protected virtual void Wearing()
    {
        // Має оператор switch який перевіряє назву зілля та викликає методи у плеер контроллера changeBuffHpItem() ChangeBuffProtectedItem() ChangeBuffMouveSpeedItem() ChangeBuffAtackItem() ChangeBuffMagicAtackItem()
    }


}
