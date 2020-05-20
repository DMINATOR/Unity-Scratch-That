using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeInstanceTicketBase : MonoBehaviour
{
    [Header("Loaded Settings")]

    [ReadOnly]
    [Tooltip("Generated playing areas")]
    public GameModeInstancePlayingAreaBase[] PlayingAreas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal virtual void UpdatePlayingAreas(GameModeInstancePlayingAreaBase[] areas)
    {
        PlayingAreas = areas;
    }
}
