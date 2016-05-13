using System;
using SimpleTeam.Mess;

namespace SimpleTeam.GameOneID.Mess
{
    using TypeID = Byte;

    [Serializable]
    public sealed class MessageProfile : MessageBase
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperTypeID.Profile;
            }
        }
        private String _nick;
        private UInt32 _honor;

        public MessageProfile(String nick, UInt32 honor)
        {
            _nick = nick;
            _honor = honor;
        }


        public string Nick
        {
            get
            {
                return _nick;
            }
            set
            {
                _nick = value;
            }
        }
        public UInt32 Honor
        {
            get
            {
                return _honor;
            }
            set
            {
                _honor = value;
            }
        }
    }
    

}
