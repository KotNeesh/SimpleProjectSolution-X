using SimpleProject.MyID.Mess;

namespace SimpleProject.Sce
{
    public interface ISceneGameMessages : ISceneScenario
    {
        void SetMessage(MessageGameMap message);
        void SetMessage(MessageGameState message);
        void SetMessage(MessageGamerCommand message);
    }
}
