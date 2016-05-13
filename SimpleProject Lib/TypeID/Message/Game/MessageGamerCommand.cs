using System;
using SimpleTeam.Mess;

namespace SimpleTeam.GameOneID.Mess
{
    using TypeID = Byte;

    [Serializable]
    public sealed class MessageGamerCommand : MessageBase
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperTypeID.GamerCommand;
            }

        }
    }
}