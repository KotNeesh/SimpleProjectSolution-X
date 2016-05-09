using System;
using System.Collections.Generic;
using SimpleProject.Comm;

namespace SimpleProject.Mess
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
	    public MessagesManager()
        {
            _scenario = new Scenario();
            _messagesNetwork = new Queue<IMessage>();
        }

        void IMessagesManagerNetwork.SetMessage(IMessage message)
        {
            
            if (message != null)
            {
                ICommandProcessMessage c = RegisterCommandProcessMessage.Find(message.Type);
                if (c != null)
                {
                    ICommand cs = new CommandProcessMessageSmart(c, message);
                    _scenario.Set(cs);
                }
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
