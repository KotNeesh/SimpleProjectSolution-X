using System;
using SimpleTeam.Mess;
using SimpleTeam.Net;

namespace SimpleTeam.Serial
{
    public interface IPacker
    {
        void CreatePacket(ref Packet packet, IMessage message);
    }
}
