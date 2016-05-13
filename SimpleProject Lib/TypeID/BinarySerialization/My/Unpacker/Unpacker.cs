using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleTeam.Serial;
using System.IO;
using SimpleTeam.Net;
using SimpleTeam.Mess;


namespace SimpleTeam.GameOneID.Serial
{
    using TypeID = Byte;
    public class Unpacker: IUnpacker
    {
        private RegisterUnpacker _register;
        public Unpacker()
        {
            _register = new RegisterUnpacker();
        }
        public PacketState CreateMessage(ref IMessage message, Packet packet)
        {
            message = null;
            if (!packet.IsReady) return PacketState.NotReady;
            if (packet.Size < sizeof(TypeID)) return PacketState.SizeOut;
            using (MemoryStream stream = new MemoryStream(packet.GetData()))
            {
                if (!stream.CanRead) throw new SystemException("haha");
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    TypeID type = reader.ReadByte();
                    IUnpackerMy unpacker = _register.Find(type);
                    return unpacker.CreateMessage(ref message, reader, packet.Size);
                }
            }
        }
    }
}
