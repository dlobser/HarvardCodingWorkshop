using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ON{

public class Interactable_PlayAnimation : Interactable
{
    public Animator animator;
    public override void HandleEnter()
    {
        base.HandleEnter();
        animator.SetTrigger("play");
    }
}


}