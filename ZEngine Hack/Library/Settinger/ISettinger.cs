using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Hack.Library.Settinger
{
    interface ISettinger
    {
        void Load();
        void Save();
        string GetKey(string key, int type = 0);
        void SetKey(string key, string value, int type = 0);
    }
}
