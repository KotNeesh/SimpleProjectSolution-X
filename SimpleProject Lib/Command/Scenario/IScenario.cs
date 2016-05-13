

namespace SimpleTeam.Comm.Scenar
{
    public interface IScenario
    {
        ICommand Get();
        void Set(ICommand command);
    }
}