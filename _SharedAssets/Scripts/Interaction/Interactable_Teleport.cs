using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ON{

public class Interactable_Teleport : Interactable
{
    public Transform camCTRL;
    public Vector3 offset;

    public override void HandleEnter()
    {
        base.HandleEnter();
        camCTRL.transform.position = this.transform.position + offset;
    }
}


}