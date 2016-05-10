using System.IO;
using System;
using System.Runtime.Serialization;
using SimpleProject.Mess;
using SimpleProject.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleProject
{
    using TypeID = Byte;

    /**
    <summary> 
    Запускает сервер.
    </summary>
    */
    class Program
    {
        static void Main(string[] args)
        {
            
            Server server = new Server();
            server.Start();
        }
    }
}
