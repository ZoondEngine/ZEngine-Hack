using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_RED.Repositories
{
    class Client
    {
        public bool IsBanned { get; private set; }
        public bool IsAdmin { get; private set; }
        public bool IsTest { get; private set; }
        public bool IsFree { get; private set; }
        public string HWID { get; private set; }
        public int Days { get; private set; }

        public Client()
        {
            ReinitializeData();
        }

        private void ReinitializeData()
        {
            IsBanned = false;
            IsAdmin = false;
            IsTest = false;
            IsFree = false;
            HWID = string.Empty;
            Days = -1;
        }

        public void CreateFromArray(string[] array)
        {
            IsBanned = Boolean.Parse(array[0]);
            IsAdmin = Boolean.Parse(array[1]);
            IsTest = Boolean.Parse(array[2]);
            IsFree = Boolean.Parse(array[3]);
            HWID = array[4];
            Days = Int32.Parse(array[5]);
        }
    }
}
