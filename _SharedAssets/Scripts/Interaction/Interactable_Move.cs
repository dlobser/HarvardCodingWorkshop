using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ON{

public class Interactable_Move : Interactable
{
    public float amount = .5f;

    public override void HandleHover()
    {
        this.transform.Translate(Random.insideUnitSphere*amount);
    }
}


}