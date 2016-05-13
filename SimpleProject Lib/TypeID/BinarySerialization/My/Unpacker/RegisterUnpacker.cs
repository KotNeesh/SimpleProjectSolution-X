using System;
using System.Collections.Generic;
using System.IO;
using SimpleTeam.Net;
using SimpleTeam.Mess;
using SimpleTeam.Serial;

namespace SimpleTeam.GameOneID.Serial
{
    using TypeID = Byte;
    /**
    <summary> 
    Реестр всех распаковщиков пакетов.
    </summary>
    */
    public class RegisterUnpacker
    {
        private Dictionary<TypeID, IUnpackerMy> _dictionary;

        public RegisterUnpacker()
        {
            _dictionary = GetDictionary();
        }
        private Dictionary<TypeID, IUnpackerMy> GetDictionary()
        {
            var assemblyType = typeof(RegisterUnpacker);

            var packers = new Dictionary<TypeID, IUnpackerMy>();
            foreach (var type in assemblyType.Assembly.GetTypes())
            {
                if (!type.IsClass)
                    continue;

                if (type.IsAbstract)
                    continue;


                if (typeof(IUnpackerMy).IsAssignableFrom(type))
                {
                    IUnpackerMy p = Activator.CreateInstance(type) as IUnpackerMy;
                    packers.Add(p.Type, p);
                }

            }

            return packers;
        }
        public IUnpackerMy Find(TypeID type)
        {
            if (_dictionary.ContainsKey(type))
                return _dictionary[type];
            return null;
        }
    }
}
