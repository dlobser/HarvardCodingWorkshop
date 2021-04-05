using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ON{

public class Interactable_SprayObject : Interactable
{
    public GameObject sprayObject;
    public Vector3 prevPosition;
    public float spacing;
    [Tooltip("Leave null to parent to the world")]
    public Transform parent;

    public override void HandleStart()
    {
        base.HandleStart();
    }

	public override void HandleHover()
	{
        if(debug){
            Debug.Log("Clicked: " + clicked);
        }
		base.HandleHover();
        if(clicked>.5f){
            if (Vector3.Distance(prevPosition, gaze.hitPosition) > spacing)
            {
                GameObject g = Instantiate(sprayObject, gaze.hitPosition, Quaternion.identity, parent);
                g.transform.LookAt(gaze.hitNormal + g.transform.position);
                prevPosition = g.transform.position;
            }
        }
	}
}

}