using System;
using System.Collections.Generic;
using SimpleTeam.Comm;
using SimpleTeam.GameOneID.Comm;
using SimpleTeam.Comm.Scenar;

namespace SimpleTeam.Mess.Man
{
    /**
    <summary> 
    Хранит очередь сообщений для отправки в интернет. 
    <para/>
    Хранит очередь доставленных из сети сообщений,
    для которых находит команду для исполнения сеценарной машиной. 
    </summary>
    */
    public class MessagesManager : IMessagesManagerNetwork, IMessagesManagerScenario
    {
        private Scenario _scenario;
        private Queue<IMessage> _messagesNetwork;

        private RegisterCommandProcessMessage _registerComm = new RegisterCommandProcessMessage();

        public MessagesManager()
        {
            _scenario = new Scenario();
            _messagesNetwork = new Queue<IMessage>();
        }

        void IMessagesManagerNetwork.SetMessage(IMessage message)
        {
            if (message != null)
            {
                ICommand cs = new CommandProcessMessageSmart(_registerComm, message);
                _scenario.Set(cs);
            }
        }

        IMessage IMessagesManagerNetwork.GetMessage()
        {
            if (_messagesNetwork.Count == 0) return null;
            else
            {
                IMessage m = null;
                lock (_messagesNetwork)
                {
                    m = _messagesNetwork.Dequeue();
                }
                return m;
            }
        }

        void IMessagesManagerScenario.SetMessage(IMessage message)
        {
            if (message != null)
            {
                lock (_messagesNetwork)
                {
                    _messagesNetwork.Enqueue(message);
                }
            }
        }

        public IScenario GetScenario()
        {
            return _scenario;
        }
    }

}
