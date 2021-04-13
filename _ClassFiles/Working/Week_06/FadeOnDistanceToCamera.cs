using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOnDistanceToCamera : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public float value;
    public float min = -1;
    public float max = 1;
    public bool isTransparent;

    void Start()
    {
        if(spriteRenderer==null)
            spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!isTransparent)
        {
            float dist = Vector3.Distance(Camera.main.transform.position, this.transform.position);
            float remappedDist = map(dist, 0, 1, min, max);
            spriteRenderer.color = new Color(1, 1, 1, remappedDist);
            if (remappedDist <= 0)
            {
                isTransparent = true;
            }
        }
    }

    float map(float s, float a1, float a2, float b1, float b2)
    {
        return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
    }
}
