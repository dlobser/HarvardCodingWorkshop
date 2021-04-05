using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ON{

public class Interactable_Destroy : Interactable
{

    public GameObject explosion;

    public override void HandleHover()
    {
        HandleTrigger();
    }

    public override void HandleTrigger()
    {
        if (explosion != null)
        {
            GameObject e = Instantiate(explosion);
            e.transform.position = this.transform.position;
        }
        Destroy(this.gameObject);
    }


}


}