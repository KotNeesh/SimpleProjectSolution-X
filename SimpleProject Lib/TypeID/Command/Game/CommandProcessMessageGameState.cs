using System;
using SimpleTeam.Comm;
using SimpleTeam.Mess;
using SimpleTeam.GameOneID.Mess;
using SimpleTeam.Comm.Scenar;

namespace SimpleTeam.GameOneID.Comm
{
    using TypeID = Byte;
    /**
    <summary> 
    Обрабатывает сообщения, пришедшие из интернета.
    </summary>
    */
    class CommandProcessMessageGameState : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.GameState;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneGameMessages p = parameters as IParametersSceneGameMessages;
            p.GetSceneGameMessages().SetMessage((MessageGameState)message);
        }
    }
}