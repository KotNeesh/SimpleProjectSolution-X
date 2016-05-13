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
    Обрабатывает сообщения игрового профиля, пришедшие из интернета.
    </summary>
    */
    class CommandProcessMessageProfile : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Profile;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneMenuMessages p = parameters as IParametersSceneMenuMessages;
            p.GetSceneMenuMessages().SetMessage((MessageProfile)message);
        }
    }
}
