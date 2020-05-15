using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tickets pack that was bought
public class BoughtTicketsPack : MonoBehaviour
{
    //Not exposed


    //Exposed

    [ReadOnly]
    [Tooltip("Game mode used by this pack")]
    public GameModeBase GameMode;

    public void Init(SaveSlotGameMode save)
    {
        GameMode = GameModeBase.AddModeByName( this.gameObject, save.Name);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
