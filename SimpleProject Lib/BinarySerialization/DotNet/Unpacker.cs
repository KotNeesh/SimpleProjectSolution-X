using System.IO;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SimpleTeam.Mess;
using System.Runtime.Serialization.Formatters.Binary;
using SimpleTeam.Net;

namespace SimpleTeam.Serial.DotNet
{


    public class Unpacker:IUnpacker
    {
        IFormatter formatter;
        public Unpacker()
        {
            formatter = new BinaryFormatter();
        }


        public PacketState CreateMessage(ref IMessage message, Packet packet)
        {
            if (!packet.IsReady) return PacketState.NotReady;
            message = null;
            using (MemoryStream stream = new MemoryStream(packet.GetData()))
            {
                try
                {
                    message = formatter.Deserialize(stream) as IMessage;
                }
                catch (Exception ex)
                {
                    message = null;
                    return PacketState.NotParse;
                }
            }
            ((MessageBase)message).Users = new List<Use.IUserNetwork>();
            return PacketState.Ok;
            
        }
    }
}
