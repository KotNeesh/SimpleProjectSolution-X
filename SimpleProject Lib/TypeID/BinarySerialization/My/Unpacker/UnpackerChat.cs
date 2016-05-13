using System;
using System.IO;
using SimpleTeam.Mess;
using SimpleTeam.Net;
using SimpleTeam.GameOneID.Mess;
using SimpleTeam.Serial;

namespace SimpleTeam.GameOneID.Serial
{
    using SizePacket = UInt16;
    using TypeID = Byte;
    public class UnpackerChat : IUnpackerMy
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Chat;
            }
        }
        public PacketState CreateMessage(ref IMessage message, BinaryReader reader, SizePacket size)
        {
            String line = reader.ReadString();
            if (reader.BaseStream.Position != size) return PacketState.SizeOut;
            message = new MessageChat(line);
            return PacketState.Ok;
        }

        
    }
}