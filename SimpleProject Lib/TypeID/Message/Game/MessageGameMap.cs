using System;
using SimpleProject.Mess;

namespace SimpleProject.MyID.Mess
{
    using TypeID = Byte;

    [Serializable]
    public sealed class MessageGameMap : MessageBase
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperTypeID.GameMap;
            }
        }
    }
}
