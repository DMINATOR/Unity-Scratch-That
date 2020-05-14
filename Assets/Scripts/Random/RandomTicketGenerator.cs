using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTicketGenerator
{
    int _seed;
    int _position;

    public RandomTicketGenerator(int seed)
    {

    }

    public void TakeNextTicket()
    {
        _position++;
    }

    public void OffsetByTickets(int offset)
    {
        var cntr = 0;

        while(cntr < offset)
        {
            TakeNextTicket();
            cntr++;
        }
    }
}
