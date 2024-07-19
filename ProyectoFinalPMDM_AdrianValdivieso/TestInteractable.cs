using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Esta clase sirve de prueba para comprobaciones con objetos con los cuales se puede
 * interactuar dentro del juego, ya sea puertas, enemigos, etc.
 */
public class TestInteractable : Interactable
{
    public override void OnFocus()
    {
        print("LOOKING AT " + gameObject.name);
    }

    public override void OnInteract()
    {
        print("INTERACTED WITH " + gameObject.name);
    }

    public override void OnLoseFocus()
    {
        print("STOPPED LOOKING AT " + gameObject.name);
    }
}
