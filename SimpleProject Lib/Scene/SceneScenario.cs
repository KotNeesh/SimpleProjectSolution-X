using SimpleProject.Comm.Scenar;

namespace SimpleProject.Sce
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
