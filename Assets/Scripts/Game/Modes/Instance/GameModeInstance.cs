using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeInstance : MonoBehaviour
{

    [Header("Variables")]

    [Tooltip("Seed used for random generation")]
    public int Seed;

    [Tooltip("Current index of generated ticket")]
    public int CurrentTicketIndex;

    private void Start()
    {
        // Set defaults
        //Locator.GameMode.Seed = Seed;
    }

    // Generates new ticket
    public void GenerateTicket()
    {
        //if( CurrentTicketIndex < Locator.GameMode.TotalTickets)
        //{
        //    foreach(var playingArea in Locator.PlayingAreas)
        //    {
        //        playingArea.GenerateResults();
        //    }

        //    CurrentTicketIndex++;
        //    /*
        //    var generatedPlayingAreas = Locator.GameMode.GenerateTicket(CurrentTicketIndex);
        //    Locator.CurrentTicket.UpdatePlayingAreas(generatedPlayingAreas);

        //    CurrentTicketIndex++;*/
        //}
    }
}
