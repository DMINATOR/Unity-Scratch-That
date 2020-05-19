using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameModeBaseLocator))]
public class GameModeBase : MonoBehaviour
{
    //Exposed

    [Header("Locator")]

    [Tooltip("Locator")]
    public GameModeBaseLocator Locator;

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
