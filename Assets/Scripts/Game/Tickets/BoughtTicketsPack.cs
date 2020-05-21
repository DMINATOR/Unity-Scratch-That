using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tickets pack that was bought
[RequireComponent(typeof(BoughtTicketsPackLocator))]
public class BoughtTicketsPack : MonoBehaviour
{
    //Not exposed

    [Header("Constants")]
    [ReadOnly]
    [Tooltip("Random generator")]
    public System.Random _random;

    //Exposed

    [Header("Locator")]

    [Tooltip("Locator")]
    public BoughtTicketsPackLocator Locator;



    [Header("Variables")]

    [Tooltip("Seed used for random generation")]
    public int Seed;

    [Tooltip("Current index of generated ticket")]
    public int CurrentTicketIndex;


    [Header("Game settings")]

    [Tooltip("Total number of tickets that will be issued")]
    public int TotalTickets;

    [Tooltip("Available prizes")]
    public BoughtTicketsWinnings[] Prizes;

    public void Init(SaveSlotBoughtTicketPack pack)
    {
        // This will be loaded from prefab collection list
        //GameMode = GameModeBase.AddModeByName( this.gameObject, pack.GameMode.Name);
    }

    // Start is called before the first frame update
    void Start()
    {
        _random = new System.Random(Seed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateNextTicket()
    {

    }
}
