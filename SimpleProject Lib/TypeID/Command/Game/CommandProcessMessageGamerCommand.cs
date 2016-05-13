using System;
using SimpleProject.Comm;
using SimpleProject.Mess;
using SimpleProject.MyID.Mess;
using SimpleProject.Comm.Scenar;

namespace SimpleProject.MyID.Comm
{
    using TypeID = Byte;
    /**
    <summary> 
    Обрабатывает сообщения, пришедшие из интернета.
    </summary>
    */
    class CommandProcessMessageGamerCommand : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.GamerCommand;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneGameMessages p = parameters as IParametersSceneGameMessages;
            p.GetSceneGameMessages().SetMessage((MessageGamerCommand)message);
        }
    }
}