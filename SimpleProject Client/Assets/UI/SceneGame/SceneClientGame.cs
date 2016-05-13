using UnityEngine;
using SimpleTeam.Comm;
using SimpleTeam.Mess;
using System;
using SimpleTeam.Comm.Scenar;
using SimpleTeam.GameOneID.Mess;

namespace SimpleTeam.Sce
{
    public class SceneClientGame : MonoBehaviour, ISceneGameMessages
    {
        //ISceneScenario
        private SceneScenario _sceneScenario = new SceneScenario();

        public IScenario GetScenario()
        {
            return ((ISceneScenario)_sceneScenario).GetScenario();
        }


        //ISceneMenuMessages

        void ISceneGameMessages.SetMessage(MessageGamerCommand message)
        {
            throw new NotImplementedException();
        }

        void ISceneGameMessages.SetMessage(MessageGameState message)
        {
            throw new NotImplementedException();
        }

        void ISceneGameMessages.SetMessage(MessageGameMap message)
        {
            throw new NotImplementedException();
        }
    }
}
