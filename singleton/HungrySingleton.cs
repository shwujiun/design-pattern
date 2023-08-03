using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal sealed class HungrySingleton
    {
        private static readonly HungrySingleton instance = new HungrySingleton();
        private HungrySingleton() { }
        public static HungrySingleton GetInstance()
        {
            return instance;

        }
    }
}
