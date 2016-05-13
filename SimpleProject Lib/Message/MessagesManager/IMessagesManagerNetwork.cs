namespace SimpleTeam.Mess.Man
{
    /**
    <summary> 
    Периферия для интернета.
    </summary>
    */
    public interface IMessagesManagerNetwork
    {
        void SetMessage(IMessage message);
        IMessage GetMessage();
    }
}
