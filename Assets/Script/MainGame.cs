﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public static MainGame instance = null;

    private void Awake()
    {
        if (instance == null) instance = this;

        else Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }
}