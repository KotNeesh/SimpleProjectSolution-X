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
    Обрабатывает сообщения чата, пришедшие из интернета.
    </summary>
    */
    class CommandProcessMessageChat : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Chat;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneMenuMessages p = parameters as IParametersSceneMenuMessages;
            p.GetSceneMenuMessages().SetMessage((MessageChat)message);
        }
    }
}
