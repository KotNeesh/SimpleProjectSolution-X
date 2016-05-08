using System.IO;
using System;
using System.Runtime.Serialization;
using SimpleProject.Mess;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleProject.Net
{
    public class Packer
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
