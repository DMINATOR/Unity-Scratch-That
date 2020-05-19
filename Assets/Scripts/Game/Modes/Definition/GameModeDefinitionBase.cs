using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeDefinitionBase : MonoBehaviour
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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
