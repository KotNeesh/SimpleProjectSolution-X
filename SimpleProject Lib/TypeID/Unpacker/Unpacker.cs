using System.IO;
using System;
using System.Runtime.Serialization;
using SimpleProject.Mess;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleProject.Net
{
    public class Unpacker
    {
        IFormatter formatter;
        public Unpacker()
        {
            formatter = new BinaryFormatter();
        }


        public PacketState CreateMessage(ref IMessage message, Packet packet)
        {
            message = null;
            using (MemoryStream stream = new MemoryStream(packet.GetData()))
            {
                message = formatter.Deserialize(stream) as IMessage;

            }
            return PacketState.Ok;
            //if (reader.BaseStream.Position != size)
        }
    }
}
