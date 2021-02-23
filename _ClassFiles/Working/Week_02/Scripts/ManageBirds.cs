using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageBirds : MonoBehaviour
{
    public int amount;
    public float speedLow = 1;
    public float speedHigh = 2;

    public float rotationSpeedLow = 1;
    public float rotationSpeedHigh = 2;

    public GameObject bird;
    GameObject[] birds;

    float[] speeds;
    float[] rotationSpeeds;


    void Start()
    {
        birds = new GameObject[amount];
        speeds = new float[amount];
        rotationSpeeds = new float[amount];

        for (int i = 0; i < amount; i++)
        {
            birds[i] = Instantiate(bird);
            birds[i].GetComponent<AnimateBird>().speed = Random.Range(7, 18);
            birds[i].GetComponent<AnimateBird>().neckOffset = Random.Range(-.5f, -2);
            birds[i].GetComponent<AnimateBird>().color = Random.ColorHSV();

            speeds[i] = Random.Range(speedLow, speedHigh);
            rotationSpeeds[i] = Random.Range(rotationSpeedLow, rotationSpeedHigh);

        }
    }

    void Update()
    {
        for (int i = 0; i < amount; i++)
        {
            if (birds[i] != null)
            {
                birds[i].transform.Rotate(0, rotationSpeeds[i] * Time.deltaTime, 0);
                birds[i].transform.Translate(0, 0, speeds[i] * Time.deltaTime);
            }
        }
    }
}
