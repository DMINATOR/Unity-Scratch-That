using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeBase
{
    // Dictionary of game mode instances
    private static Dictionary<string, GameModeBase> _gameModes = new Dictionary<string, GameModeBase>()
    {
        { nameof(PrototypeGameMode),  new PrototypeGameMode() }
    };


    public static GameModeBase GetModeByName(string name)
    {
        return _gameModes[name];
    }
}
