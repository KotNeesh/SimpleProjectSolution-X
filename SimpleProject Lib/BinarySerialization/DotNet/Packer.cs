using System.IO;
using System;
using System.Runtime.Serialization;
using SimpleTeam.Mess;
using System.Runtime.Serialization.Formatters.Binary;
using SimpleTeam.Net;

namespace SimpleTeam.Serial.DotNet
{
    public class Packer:IPacker
    {
        IFormatter formatter;
        public Packer()
        {
            formatter = new BinaryFormatter();
        }


        public void CreatePacket(ref Packet packet, IMessage message)
        {
            packet = null;
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, message);
                packet = new Packet(stream.ToArray());
            }
        }
    }
}
