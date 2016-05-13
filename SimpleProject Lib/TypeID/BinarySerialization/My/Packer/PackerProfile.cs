using System;
using System.IO;
using SimpleTeam.Mess;
using SimpleTeam.GameOneID.Mess;

namespace SimpleTeam.GameOneID.Serial
{
    using TypeID = Byte;
    class PackerProfile : IPackerMy
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Profile;
            }
        }
        public void CreatePacket(BinaryWriter writer, IMessage message)
        {
            MessageProfile m = (MessageProfile)message;
            writer.Write(m.Nick);
            writer.Write(m.Honor);
        }
    }
}
