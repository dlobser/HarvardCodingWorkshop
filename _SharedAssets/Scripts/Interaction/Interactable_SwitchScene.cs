﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable_SwitchScene : Interactable
{

    public string scene;

    public override void HandleHover()
    {
        base.HandleHover();
        if (clicked > .5)
        {
            SceneManager.LoadScene(scene);
        }
    }

	public override void HandleTrigger()
	{
        SceneManager.LoadScene(scene);
	}
}
