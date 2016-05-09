using System;


namespace SimpleProject.Mess
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