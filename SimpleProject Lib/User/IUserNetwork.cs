using System.Collections.Generic;
using System.Net.Sockets;
using SimpleTeam.Net;

namespace SimpleTeam.Use
{
    public interface IUserNetwork
    {
        TcpClient Socket { get; set; }
        Queue<Packet> PacketsSend { get; }
        Packet PacketReceive { get; }
    }
}
