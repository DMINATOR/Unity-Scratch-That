using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameModeInstanceLocator))]
public class GameModeInstance : MonoBehaviour
{

    [Header("Locator")]

    [Tooltip("Locator")]
    public GameModeInstanceLocator Locator;

    [Header("Variables")]

    [Tooltip("Seed used for random generation")]
    public int Seed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
