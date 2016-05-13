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
    public class UnpackerAccount: IUnpackerMy
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Account;
            }
        }
        public PacketState CreateMessage(ref IMessage message, BinaryReader reader, SizePacket size)
        {
            bool success = reader.ReadBoolean();
            if (reader.BaseStream.Position >= size) return PacketState.SizeOut;
            Byte type = reader.ReadByte();
            if (reader.BaseStream.Position >= size) return PacketState.SizeOut;
            //Byte value = reader.ReadByte();
            //if (reader.BaseStream.Position >= size) return PacketState.SizeOut;
            String email = reader.ReadString();
            if (reader.BaseStream.Position >= size) return PacketState.SizeOut;
            String password = reader.ReadString();
            if (reader.BaseStream.Position >= size) return PacketState.SizeOut;
            String nick = reader.ReadString();
            if (reader.BaseStream.Position != size) return PacketState.SizeOut;
            message = new MessageAccount(email, password, nick, success, type);//value);
            return PacketState.Ok;
        }
        
    }
}
