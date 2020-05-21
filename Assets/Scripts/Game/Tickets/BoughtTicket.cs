using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoughtTicketLocator))]
public class BoughtTicket : MonoBehaviour
{
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
}
