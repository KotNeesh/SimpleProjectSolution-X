using System;
using SimpleTeam.Mess;
using SimpleTeam.Net;

namespace SimpleTeam.Serial
{
    public enum PacketState : Byte
    {
        Ok = 0,
        NotReady = 1,
        NotFoundType = 2,
        SizeOut = 3,
        NotParse = 4
    }
    public interface IUnpacker
    {
        PacketState CreateMessage(ref IMessage message, Packet packet);
    }
}
