using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TCPMessage : Message
{
    public TCPMessage() 
    {
        behavior = new TCPBehavior();
    }
}
