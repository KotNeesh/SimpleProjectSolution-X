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
    public class UnpackerProfile : IUnpackerMy
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Profile;
            }
        }
        public PacketState CreateMessage(ref IMessage message, BinaryReader reader, SizePacket size)
        {
            String nick = reader.ReadString();
            if (reader.BaseStream.Position >= size) return PacketState.SizeOut;
            UInt32 honor = reader.ReadUInt32();
            if (reader.BaseStream.Position != size) return PacketState.SizeOut;
            message = new MessageProfile(nick, honor);
            return PacketState.Ok;
        }

    }
}
