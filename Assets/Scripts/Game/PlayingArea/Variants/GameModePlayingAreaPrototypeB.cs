using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModePlayingAreaPrototypeB : GameModePlayingAreaBase
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
        return new GameModeInstancePlayingAreaPrototypeB
        {
            PlayingArea = this
        };
    }
}
