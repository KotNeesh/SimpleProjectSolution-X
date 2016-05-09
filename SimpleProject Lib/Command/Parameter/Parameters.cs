﻿using SimpleProject.Sce;
using SimpleProject.Mess;
using System.Collections.Generic;
using System;

namespace SimpleProject.Comm
{

    /**
    <summary> 
    Хранит все необходимые параметры для исполнения команд.
    </summary>
    */
    public class Parameters : IParameters,
        IParametersSceneMenuMessages,
        IParametersSceneGameMessages,
        IParametersMessagesManagerScenario
    {

        ISceneMenuMessages _sceneMenu;
        ISceneGameMessages _sceneGame;
        IMessagesManagerScenario _messagesManager;
        public Parameters(ISceneMenuMessages sceneMenu, ISceneGameMessages sceneGame, IMessagesManagerScenario messagesManager)
        {
            _sceneMenu = sceneMenu;
            _sceneGame = sceneGame;
            _messagesManager = messagesManager;
        }

        List<IScenario> IParameters.GetAllScenario()
        {
            List<IScenario> scenarios = new List<IScenario>();
            scenarios.Add(_sceneMenu.GetScenario());
            scenarios.Add(_sceneGame.GetScenario());
            scenarios.Add(_messagesManager.GetScenario());
            return scenarios;
        }

        ISceneMenuMessages IParametersSceneMenuMessages.GetSceneMenuMessages()
        {
            return _sceneMenu;
        }


        ISceneGameMessages IParametersSceneGameMessages.GetSceneGameMessages()
        {
            return _sceneGame;
        }


        IMessagesManagerScenario IParametersMessagesManagerScenario.GetMessagesManagerScenario()
        {
            return _messagesManager;
        }

       
    }
}