public class TCPBehavior : Behavior
{
    public void Receive()
    {
        Console.WriteLine("TCP Receive");
    }

    public void Send()
    {
        Console.WriteLine("TCP Send");
    }
}
