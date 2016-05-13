using SimpleTeam.GameOneID.Mess;

namespace SimpleTeam.Sce
{
    /**
    <summary>
    Интерфейс обработки сообщений меню сценой
    </summary>
    */
    public interface ISceneMenuMessages : ISceneScenario
    {
        void SetMessage(MessageChat message);
        void SetMessage(MessageAccount message);
        void SetMessage(MessageProfile message);
    }
}
