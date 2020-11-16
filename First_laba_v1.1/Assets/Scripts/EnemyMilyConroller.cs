using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMilyConroller : EnemyControllerBase
{
    public override void TakeDamage(int damage, DamageType type = DamageType.Casual, Transform palyer = null)
    {
        if (type != DamageType.Projectile)
            return;

        base.TakeDamage(damage, type, palyer);
    }

}
