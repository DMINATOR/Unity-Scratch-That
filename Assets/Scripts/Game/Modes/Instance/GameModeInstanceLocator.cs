using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeInstanceLocator : MonoBehaviour
{
    [Tooltip("Game mode that will be used for generating tickets")]
    public GameModeDefinitionBase GameMode;

    [Tooltip("Statistics of generation results so far")]
    public GameModeInstanceStatistics Statistics;

    [Tooltip("Current generated ticket")]
    public GameModeInstanceTicketBase CurrentTicket;
}
