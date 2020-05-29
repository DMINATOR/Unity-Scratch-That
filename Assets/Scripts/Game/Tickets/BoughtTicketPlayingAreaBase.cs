using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoughtTicketPlayingAreaBase : MonoBehaviour
{
    [Header("Variables")]

    [Tooltip("Seed used for this playing area generation")]
    public int Seed;

    [Tooltip("Winning Prizes that this playing area can provide")]
    public int[] WinningPrizes;

    [Header("Status")]

    [ReadOnly]
    [Tooltip("Random generator")]
    public System.Random _random;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ApplySeed(int seed, int offset)
    {
        Seed = seed;
        _random = new System.Random(seed);

        for (var i = 0; i < offset; i++)
        {
            _random.Next();
        }
    }
}
