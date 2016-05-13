using System;
using SimpleProject.Mess;

using System.IO;

namespace SimpleProject.MyID.Serial
{
    using SizePacket = UInt16;
    public interface IPacker : ITypeID
    {
        void CreatePacket(BinaryWriter writer, IMessage message);
    }
}
