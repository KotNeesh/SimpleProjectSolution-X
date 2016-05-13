using SimpleProject.Comm;
using SimpleProject.Mess;

namespace SimpleProject.MyID.Comm
{
    public interface ICommandProcessMessage : ITypeID
    {
        void Do(IParameters parameters, IMessage message);
    }
}
