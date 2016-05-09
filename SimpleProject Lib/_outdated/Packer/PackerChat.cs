using System;
using System.IO;
using SimpleProject.Mess;


namespace SimpleProject._outdated.Mess
{
    using TypeID = Byte;
    public class PackerChat : IPacker
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
