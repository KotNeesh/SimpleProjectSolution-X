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
    class CommandProcessMessageGameMap : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.GameMap;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneGameMessages p = parameters as IParametersSceneGameMessages;
            p.GetSceneGameMessages().SetMessage((MessageGameMap)message);
        }
    }
}
