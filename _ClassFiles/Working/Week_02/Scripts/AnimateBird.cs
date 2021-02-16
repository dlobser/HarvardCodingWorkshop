using UnityEngine;

public class AnimateBird : MonoBehaviour
{
    public float speed;
    public float offset;
    public float multiply;

    public float neckMultiply;
    public float neckOffset;

    public float bodyMultiply;
    public float bodyOffset;

    float wingRotation;
    float wingRotation2;
    float neckRotation;
    float bodyPosition;

    public Transform rWing;
    public Transform lWing;
    public Transform neck;
    public Transform body;

    float LFO;


    void Start()
    {

    }

    void Update()
    {
        LFO = Mathf.Sin(Time.time * speed * .1f);

        wingRotation = Mathf.Sin(Time.time * speed) * multiply * LFO;
        wingRotation2 = Mathf.Sin(Time.time * speed + offset) * multiply * LFO;
        neckRotation = Mathf.Sin(Time.time * speed + neckOffset) * neckMultiply * LFO;
        bodyPosition = Mathf.Sin(Time.time * speed + bodyOffset) * bodyMultiply * LFO;


        rWing.localEulerAngles = new Vector3(0, 0, wingRotation );
        rWing.GetChild(0).localEulerAngles = new Vector3(0, 0, wingRotation2);

        lWing.localEulerAngles = new Vector3(0, 0, wingRotation);
        lWing.GetChild(0).localEulerAngles = new Vector3(0, 0, wingRotation2);

        neck.localEulerAngles = new Vector3(neckRotation, 0 , 0);
        body.localPosition = new Vector3(0, bodyPosition, 0);

    }
}
