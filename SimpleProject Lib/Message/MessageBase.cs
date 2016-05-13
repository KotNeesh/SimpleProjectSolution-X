using System.Collections.Generic;
using SimpleTeam.Use;
using System;

namespace SimpleTeam.Mess
{
    /**
    <summary>
    Хранит список юзеров от кого отправлено\кому отправить сообщение.
    </summary>
    */
    [Serializable]
    public abstract class MessageBase : IMessage
    {
        public abstract byte Type { get; }
        [NonSerialized] public List<IUserNetwork> Users;
        protected MessageBase()
        {
            Users = new List<IUserNetwork>();
        }

        
    }
}


 

