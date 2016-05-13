using SimpleTeam.Mess;
using SimpleTeam.Comm.Scenar;

namespace SimpleTeam.Comm
{
    /**
    <summary>
    Команда для отправки сообщения в интернет.
    </summary>
    */
    public class CommandSendMessageNetwork : ICommand
    {
        IMessage _message;
        public CommandSendMessageNetwork(IMessage message)
        {
            _message = message;
        }

        void ICommand.Do(IParameters parameters)
        {
            IParametersMessagesManagerScenario p = parameters as IParametersMessagesManagerScenario;
            p.GetMessagesManagerScenario().SetMessage(_message);
        }
    }
}
