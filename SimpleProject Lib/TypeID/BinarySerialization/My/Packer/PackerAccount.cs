using System;
using SimpleProject.Mess;
using System.IO;
using SimpleProject.MyID.Mess;

namespace SimpleProject.MyID.Serial
{
    using TypeID = Byte;
    public class PackerAccount : IPacker
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Account;
            }
        }
        public void CreatePacket(BinaryWriter writer, IMessage message)
        {
            MessageAccount m = (MessageAccount)message;
            //writer.Write(m.StateValue);
            writer.Write(m.Success);
            writer.Write((Byte)m.State);
            writer.Write(m.Email);
            writer.Write(m.Password);
            writer.Write(m.Nick);
        }
        
    }
}
