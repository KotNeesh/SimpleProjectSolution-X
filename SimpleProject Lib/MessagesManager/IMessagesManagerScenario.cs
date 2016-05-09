using SimpleProject.Comm;

namespace SimpleProject.Mess
{
    /**
    <summary> 
    Переферия для внутренних сообщеий.
    </summary>
    */
    public interface IMessagesManagerScenario
    {
        void SetMessage(IMessage message);
        IScenario GetScenario();
    }
}
