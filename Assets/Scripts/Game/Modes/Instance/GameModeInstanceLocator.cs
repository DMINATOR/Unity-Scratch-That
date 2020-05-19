using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeInstanceLocator : MonoBehaviour
{
    [Tooltip("Game mode")]
    public GameModeDefinitionBase GameMode;

    [Tooltip("Statistics")]
    public GameModeInstanceStatistics Statistics;
}
