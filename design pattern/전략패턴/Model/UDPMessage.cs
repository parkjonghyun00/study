using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UDPMessage : Message
{
    public UDPMessage() 
    {
        behavior = new UdpBehavior();
    }
}
