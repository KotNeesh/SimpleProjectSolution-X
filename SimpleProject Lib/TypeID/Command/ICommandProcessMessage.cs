using SimpleTeam.Comm;
using SimpleTeam.Mess;

namespace SimpleTeam.GameOneID.Comm
{
    public interface ICommandProcessMessage : ITypeID
    {
        void Do(IParameters parameters, IMessage message);
    }
}
