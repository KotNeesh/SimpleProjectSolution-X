using System;
using SimpleTeam.Mess;
using System.IO;
using SimpleTeam.GameOneID.Mess;

namespace SimpleTeam.GameOneID.Serial
{
    using TypeID = Byte;
    public class PackerAccount : IPackerMy
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
