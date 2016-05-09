namespace SimpleProject.Mess
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
