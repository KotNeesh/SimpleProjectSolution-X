using System;
using SimpleProject.Mess;

using System.IO;

namespace SimpleProject._outdated.Mess
{
    using SizePacket = UInt16;
    public interface IPacker : ITypeID
    {
        void CreatePacket(BinaryWriter writer, IMessage message);
    }
}
