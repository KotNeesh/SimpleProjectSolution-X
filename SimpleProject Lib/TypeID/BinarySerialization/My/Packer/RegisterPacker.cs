using System;
using System.Collections.Generic;
using System.IO;
using SimpleTeam.Net;
using SimpleTeam.Mess;

namespace SimpleTeam.GameOneID.Serial
{
    
    using TypeID = Byte;
    /**
    <summary> 
    Реестр всех упаковщиков сообщений.
    </summary>
    */
    public class RegisterPacker
    {

        private Dictionary<TypeID, IPackerMy> _dictionary;
        public RegisterPacker()
        {
            _dictionary = GetDictionary();
        }
        private Dictionary<TypeID, IPackerMy> GetDictionary()
        {
            var assemblyType = typeof(RegisterPacker);

            var packers = new Dictionary<TypeID, IPackerMy>();
            foreach (var type in assemblyType.Assembly.GetTypes())
            {
                if (!type.IsClass)
                    continue;

                if (type.IsAbstract)
                    continue;


                if (typeof(IPackerMy).IsAssignableFrom(type))
                {
                    IPackerMy p = Activator.CreateInstance(type) as IPackerMy;
                    packers.Add(p.Type, p);
                }
                    
            }

            return packers;
        }
        public IPackerMy  Find(TypeID type)
        {
            if (_dictionary.ContainsKey(type))
                return _dictionary[type];
            return null;
        }
    }
}
