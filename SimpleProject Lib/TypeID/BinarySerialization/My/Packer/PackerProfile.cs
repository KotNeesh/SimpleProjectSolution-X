using System;
using System.IO;
using SimpleProject.Mess;
using SimpleProject.MyID.Mess;

namespace SimpleProject.MyID.Serial
{
    using TypeID = Byte;
    class PackerProfile : IPacker
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
