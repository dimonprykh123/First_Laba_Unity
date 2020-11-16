using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] int _damage;

    private void OnTriggerEnter2D(Collider2D info)
    {
        EnemyControllerBase enemy = info.GetComponent<EnemyControllerBase>();
        enemy.TakeDamage(_damage);
        Destroy(gameObject);
    }
}
