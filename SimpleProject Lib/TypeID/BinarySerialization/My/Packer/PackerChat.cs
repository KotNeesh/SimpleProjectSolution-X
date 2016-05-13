using System;
using System.IO;
using SimpleTeam.Mess;
using SimpleTeam.GameOneID.Mess;

namespace SimpleTeam.GameOneID.Serial
{
    using TypeID = Byte;
    public class PackerChat : IPackerMy
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Chat;
            }
        }
        public void CreatePacket(BinaryWriter writer, IMessage message)
        {
            MessageChat m = (MessageChat)message;
            writer.Write(m.Line);
        }
        public PackerChat()
        { }
    }
}
