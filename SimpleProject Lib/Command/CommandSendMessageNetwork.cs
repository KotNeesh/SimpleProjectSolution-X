using SimpleProject.Mess;
using SimpleProject.Comm.Scenar;

namespace SimpleProject.Comm
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
