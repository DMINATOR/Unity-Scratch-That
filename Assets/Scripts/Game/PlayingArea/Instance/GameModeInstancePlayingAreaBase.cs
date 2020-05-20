using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameModeInstancePlayingAreaBase : MonoBehaviour
{
    [Tooltip("Playing area that created this instance")]
    public GameModePlayingAreaBase PlayingArea;
}