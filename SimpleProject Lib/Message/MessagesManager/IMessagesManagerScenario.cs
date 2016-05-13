using SimpleTeam.Comm.Scenar;

namespace SimpleTeam.Mess.Man
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
