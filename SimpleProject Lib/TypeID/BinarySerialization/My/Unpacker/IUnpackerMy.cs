using System;
using SimpleTeam.Mess;
using SimpleTeam.Net;
using System.IO;
using SimpleTeam.Serial;

namespace SimpleTeam.GameOneID.Serial
{
    using SizePacket = UInt16;

    public interface IUnpackerMy : ITypeID
    {
        PacketState CreateMessage(ref IMessage message, BinaryReader reader, SizePacket size);
    }
}
