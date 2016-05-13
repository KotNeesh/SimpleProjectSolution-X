using System;
using SimpleProject.Mess;
using SimpleProject.Net;
using System.IO;

namespace SimpleProject.MyID.Serial
{
    using SizePacket = UInt16;

    public interface IUnpacker : ITypeID
    {
        PacketState CreateMessage(ref IMessage message, BinaryReader reader, SizePacket size);
    }
}
