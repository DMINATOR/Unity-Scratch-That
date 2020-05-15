using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeBase : MonoBehaviour
{
    /*
    // Dictionary of game mode instances
    private static Dictionary<string, GameModeBase> _gameModes = new Dictionary<string, GameModeBase>()
    {
        { nameof(PrototypeGameMode),  new PrototypeGameMode() }
    };
    */

    public static GameModeBase AddModeByName(GameObject parentGameObject, string name)
    {
        //return _gameModes[name];
        switch(name)
        {
            case nameof(PrototypeGameMode):
                return parentGameObject.AddComponent<PrototypeGameMode>();

            default:
                throw new System.Exception($"Unknown game mode {name}");
        }

    }
}
