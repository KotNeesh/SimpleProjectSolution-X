using System;
using SimpleTeam.Mess;

using System.IO;

namespace SimpleTeam.GameOneID.Serial
{
    using SizePacket = UInt16;
    public interface IPackerMy : ITypeID
    {
        void CreatePacket(BinaryWriter writer, IMessage message);
    }
}
