using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject.Sce
{
    public class SimplusParty
    {
        public uint ID { get; set; }
        public bool IsMyID(SimplusParty party)
        {
            return ID == party.ID;
        }
    }
}
