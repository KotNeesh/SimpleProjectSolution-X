using SimpleTeam.Comm.Scenar;

namespace SimpleTeam.Sce
{
    public class SceneScenario : ISceneScenario
    {
        protected IScenario _scenario;
        public SceneScenario()
        {
            _scenario = new Scenario();
        }
        public IScenario GetScenario()
        {
            return _scenario;
        }
    }
}
