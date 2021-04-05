using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ON{


public class Interactable_Grabbable : Interactable
{

    bool grab;
    bool prevGrab;
    Transform oldParent;
    Vector3 prevPos;
    public float moveTowardGrabberSpeed = 0;
    public float stopGrabbingDistance = .25f;
    List<Vector3> positions;

	public override void HandleStart()
	{
		base.HandleStart();
        positions = new List<Vector3>();
        oldParent = this.transform.parent;
	}

	public override void HandleUpdate()
	{
		base.HandleUpdate();

        if (debug)
            Debug.Log("grabbed: " + grab + " , " + prevGrab);

        if (gaze != null)
        {
            if (gaze.button.click < .9f && grab)
            {
                grab = false;
            }

            if (!grab && prevGrab)
            {
                if (this.GetComponent<Rigidbody>() != null)
                {
                    this.GetComponent<Rigidbody>().isKinematic = false;
                    this.GetComponent<Rigidbody>().AddForce((GetAverageSpeed())/Time.deltaTime,ForceMode.VelocityChange);
                }
                this.transform.parent = oldParent;
            }

            prevGrab = grab;

        }
        if (Vector3.Distance(prevPos, this.transform.position) > .01f)
        {
            positions.Add(this.transform.position-prevPos);
            if (positions.Count > 10)
            {
                positions.RemoveAt(0);
            }
            prevPos = this.transform.position;
        }

	}

    Vector3 GetAverageSpeed()
    {
        Vector3 temp = Vector3.zero;
        for (int i = 0; i < positions.Count; i++)
        {
            temp += positions[i];
        }
        return temp / positions.Count;
    }

    public override void HandleHover()
    {
        base.HandleHover();
        float distance = Vector3.Distance(this.transform.position, gaze.transform.position);
        if (gaze.button.click > .9f && distance < minDistance)
        {
            if (debug)
                Debug.Log("clicked");
            this.transform.parent = gaze.transform;
            if(distance>stopGrabbingDistance)
                this.transform.position = Vector3.Lerp(
                this.transform.position, 
                gaze.transform.position, 
                moveTowardGrabberSpeed * Time.deltaTime);
            if (this.GetComponent<Rigidbody>() != null)
                this.GetComponent<Rigidbody>().isKinematic = true;
            grab = true;
        }
       
        
    }

}


}