using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanism : Interacteble 
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void ConfirmInteract()
    {
        InteracionWithMech();
    }

    protected override void DeclineInteract()
    {
        base.DeclineInteract();
    }

    private void InteracionWithMech()
    { 
    // Виконує взаємодію з механізмом 
    }
}
