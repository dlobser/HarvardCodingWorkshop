using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnSprites : MonoBehaviour
{
    public SpriteRenderer[] sprites;

    public float fadeSpeed;
    public float gapSpeed;

    public float fadeCounter;
    public float gapCounter;

    public int whichSprite;

    public Color color = Color.white;

    public bool trigger;


    //turn all the sprites off
    //count up a float by the fade speed
    //count up a float by the gap speed
    //iterate up the index of the sprite when the fade speed == 1

    // Start is called before the first frame update
    void Start()
    {
        color.a = 0;
        for (int i = 0; i < sprites.Length; i++)
        {
            sprites[i].color = color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            if (fadeCounter < 1)
            {
                fadeCounter += Time.deltaTime * (1 / fadeSpeed);
            }
            else if (gapCounter < 1)
            {
                gapCounter += Time.deltaTime * (1 / gapSpeed);
            }
            else
            {
                if (whichSprite + 1 < sprites.Length)
                {
                    whichSprite++;
                    fadeCounter = 0;
                    gapCounter = 0;

                }
            }

            color.a = fadeCounter;
            sprites[whichSprite].color = color;
        }
    }
}
