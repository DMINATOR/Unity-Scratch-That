using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoughtTicketLocator))]
public class BoughtTicket : MonoBehaviour
{
    [Header("Constants")]

    [ReadOnly]
    [Tooltip("Seed Offset value")]
    public static int SEED_OFFSET = 100000;

    //Exposed

    [Header("Locator")]

    [Tooltip("Locator")]
    public BoughtTicketLocator Locator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ShowGenerationResults()
    {
        foreach( var playingArea in Locator.PlayingAreas)
        {

        }
    }

    internal void ApplySeed(int seed, int offset)
    {
        var seedCounter = seed;
        foreach (var playingArea in Locator.PlayingAreas)
        {
            seedCounter += SEED_OFFSET;
            playingArea.Seed = seedCounter;
        }
    }

    internal void GenerateWin(BoughtTicketsWinnings winningTicket)
    {
        
    }

    internal void GenerateLoose()
    {
        
    }
}
