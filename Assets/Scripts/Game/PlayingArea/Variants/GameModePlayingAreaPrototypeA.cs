﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModePlayingAreaPrototypeA : GameModePlayingAreaBase
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal override GameModeInstancePlayingAreaBase GenerateResults()
    {
        return new GameModeInstancePlayingAreaPrototypeA
        {
            PlayingArea = this
        };
    }
}
