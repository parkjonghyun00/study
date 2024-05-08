using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UdpBehavior : Behavior
{
    public void Receive()
    {
        Console.WriteLine("UDP Receive");
    }

    public void Send()
    {
        Console.WriteLine("UDP Send");
    }
}
