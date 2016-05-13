using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SimpleTeam.Sce
{
    interface ISimplusInfoServer : ISimplusInfo
    {
        void IncHP(int HP, SimplusInfo source);
    }
}