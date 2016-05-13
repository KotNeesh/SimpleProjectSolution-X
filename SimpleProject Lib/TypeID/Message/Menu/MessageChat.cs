using System;
using SimpleTeam.Mess;

namespace SimpleTeam.GameOneID.Mess
{
    using TypeID = Byte;

    [Serializable]
    public sealed class MessageChat : MessageBase
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperTypeID.Chat;
            }
        }

        public string Line;
        public MessageChat(String line)
        {
            Line = line;
        }
    };
}