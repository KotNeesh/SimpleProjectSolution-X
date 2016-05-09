using UnityEngine;
using SimpleProject.Comm;
using SimpleProject.Mess;
using System;

namespace SimpleProject.Sce
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
