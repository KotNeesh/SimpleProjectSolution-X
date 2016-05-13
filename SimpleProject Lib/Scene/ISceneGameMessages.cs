using SimpleTeam.GameOneID.Mess;

namespace SimpleTeam.Sce
{
    public interface ISceneGameMessages : ISceneScenario
    {
        void SetMessage(MessageGameMap message);
        void SetMessage(MessageGameState message);
        void SetMessage(MessageGamerCommand message);
    }
}
