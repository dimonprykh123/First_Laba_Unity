using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemPicker : MonoBehaviour
{
    [SerializeField] int _heal;
    [SerializeField] int _mana;
    [SerializeField] int _coins;
    [SerializeField] TMP_Text _txt;
    private void OnTriggerEnter2D(Collider2D info)
    {
         if (gameObject.name.Contains("Heall"))
         {
            info.GetComponent<PlayerController>().RestoreHP(_heal);
            Destroy(gameObject);
        }
         else if (gameObject.name.Contains("Mana"))
         {
             info.GetComponent<PlayerController>().ChangeMP(_mana);
             Destroy(gameObject);
         }
         else if (gameObject.name.Contains("Coins")) {
             info.GetComponent<PlayerController>().ChangeCoins(_coins);
             Destroy(gameObject);
         }
}
}
