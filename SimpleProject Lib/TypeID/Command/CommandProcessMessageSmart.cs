using SimpleProject.Mess;
using SimpleProject.Comm;

namespace SimpleProject.MyID.Comm
{
    /**
    <summary>
    Команда для обработки сообщения из интернета.
    </summary>
    */
    public class CommandProcessMessageSmart : ICommand
    {

        RegisterCommandProcessMessage _register;
        private IMessage _message;
        public CommandProcessMessageSmart(RegisterCommandProcessMessage register, IMessage message)
        {
            _register = register;
            _message = message;
        }

        void ICommand.Do(IParameters parameters)
        {
            ICommandProcessMessage c = _register.Find(_message.Type);
            if (c != null)
            {
                c.Do(parameters, _message);
            }
        }
    }
}
