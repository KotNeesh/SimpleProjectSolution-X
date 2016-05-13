﻿using System.IO;
using System;
using System.Runtime.Serialization;
using SimpleTeam.Mess;
using SimpleTeam.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleTeam
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
