using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameModeDefinitionBase : MonoBehaviour
{
    //Exposed

    //[Header("Locator")]

    //[Tooltip("Locator")]
    //public OpenWorldControllerLocator Locator;

    [Header("Variables")]

    [Tooltip("Total number of tickets that will be issued")]
    public int TotalTickets;

    [Tooltip("Table of all possible winnings")]
    public GameModeWinnings[] WinningsTable;

    [Tooltip("Assigned playing areas")]
    public GameModePlayingAreaBase[] PlayingAreas = null;


    [Header("Status")]

    [ReadOnly]
    [Tooltip("Seed for random generation")]
    public int Seed;


    internal GameModeInstancePlayingAreaBase[] GenerateTicket(int index)
    {
        var results = new List<GameModeInstancePlayingAreaBase>();

        foreach (var playingArea in PlayingAreas)
        {
            results.Add(playingArea.GenerateResults());
        }

        return results.ToArray();
    }
}
