using System;


namespace SimpleProject.MyID
{
    using TypeID = Byte;
    /**
    <summary> 
    Реестр всех типов сообщений.
    </summary>
    */
    public enum HelperTypeID : TypeID
    {
        Account,
        Chat,
        Profile,
        GameMap,
        GameState,
        GamerCommand
    }
}
