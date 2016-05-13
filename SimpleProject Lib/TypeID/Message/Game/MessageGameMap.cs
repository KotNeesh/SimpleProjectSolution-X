using System;
using SimpleTeam.Mess;

namespace SimpleTeam.GameOneID.Mess
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
