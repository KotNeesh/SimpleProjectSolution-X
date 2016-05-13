

namespace SimpleProject.Comm.Scenar
{
    public interface IScenario
    {
        ICommand Get();
        void Set(ICommand command);
    }
}