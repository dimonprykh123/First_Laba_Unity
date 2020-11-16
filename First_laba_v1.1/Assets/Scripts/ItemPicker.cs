using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    [SerializeField] int _heal;
    private void OnTriggerEnter2D(Collider2D info)
    {
        info.GetComponent<PlayerController>().ResoreHP(_heal);
        Destroy(gameObject);
    }
}
