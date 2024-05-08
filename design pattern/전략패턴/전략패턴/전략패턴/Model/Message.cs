using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Message
{
    protected Behavior behavior;

    public void Send()
    {
        behavior.Send();
    }

    public void Receive()
    {
        behavior.Receive();
    }
}
