using System;
using SimpleTeam.Mess;

namespace SimpleTeam.GameOneID.Mess
{
    using TypeID = Byte;

    [Serializable]
    public sealed class MessageGameState : MessageBase
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperTypeID.GameState;
            }
        }
    }
}