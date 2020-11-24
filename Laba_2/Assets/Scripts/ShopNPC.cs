using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCShop : NPC
{
    // Всі підписки на слухачі івентів відбулись тута!
    // Створення єкземплярів також тута !
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void NextDialogScene()
    {
        base.NextDialogScene();
    }

    protected override void ConfirmInteract()
    {
        base.ConfirmInteract();
    }

    protected override void DeclineInteract()
    {
        base.DeclineInteract();
    }
    protected void BuyItem() 
    {
        // Переміщує айтем до вікна купівлі 
        // Викликає методи із інстенсу айтемів (ChangeItemCount(int count, string itemName), ChangeGold(int gold))
    }

    protected void SaleItem()
    {
        // Переміщує айтем до вікна продажу
        // Викликає методи із інстенсу айтемів (ChangeItemCount(int count, string itemName), ChangeGold(int gold))
    }

    protected void AcceptDeal()
    {
        OutInteract();
        // Підтвердження Обміну Продажу або Купівлі
        // Викликає методи із інстенсу айтемів
        // Викликає методи із інстенсу айтемів (ChangeItemCount(int count, string itemName), ChangeGold(int gold))
    }

    protected void DeclineDeal()
    {
        OutInteract();
        // Відхілення угоди 
        // Викликає методи із інстенсу айтемів (ChangeItemCount(int count, string itemName), ChangeGold(int gold))
    }
}
