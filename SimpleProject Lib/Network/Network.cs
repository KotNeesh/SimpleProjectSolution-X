using System.Net.Sockets;
using System;
using SimpleTeam.Use;

namespace SimpleTeam.Net
{
    using SizePacket = UInt16;
    /**
    <summary> 
    Обертка на уровне пакетов над TCP протоколом. 
    </summary>
    */
    public static class Network
    {
        private static NetworkParser _parser = new NetworkParser();
        public static void Send(IUserNetwork user)
        {
            if (!user.Socket.Connected) return;

            NetworkStream stream = user.Socket.GetStream();
            while (user.PacketsSend.Count != 0)
            {
                Packet packet = user.PacketsSend.Dequeue();
                _parser.SendPacket(packet, stream);
            }
        }
        public static void Receive(IUserNetwork user)
        {
            if (!user.Socket.Connected) return;

            NetworkStream stream = user.Socket.GetStream();

            Packet packet = user.PacketReceive;
            _parser.ReceivePacket(packet, stream);

        }
    }
}
