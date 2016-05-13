using SimpleProject.Comm.Scenar;

namespace SimpleProject.Mess.Man
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
