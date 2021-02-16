using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSomething : MonoBehaviour
{

    //int
    //float
    //bool
    //string

    //GameObject
    //Transform
    //Vector3

    public string Hello = "Hello World!";
    public int intVariable;
    public float floatVariable;
    public bool boolVariable;

    public float x;
    public float y;
    public float z;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        print(Hello + " , " + intVariable + " , " + floatVariable + " , " + boolVariable);
    }

    // Update is called once per frame
    void Update()
    {
        print(Hello + " , " + intVariable + " , " + floatVariable + " , " + boolVariable);
        x += speed;
        this.transform.position = new Vector3(x, y, z);
    }
}
