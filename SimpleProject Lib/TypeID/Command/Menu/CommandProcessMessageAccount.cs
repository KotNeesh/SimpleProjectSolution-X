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
    Обрабатывает сообщения аккаунта, пришедшие из интернета.
    </summary>
    */
    class CommandProcessMessageAccount : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Account;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneMenuMessages p = parameters as IParametersSceneMenuMessages;
            p.GetSceneMenuMessages().SetMessage((MessageAccount)message);
        }
    }
}
