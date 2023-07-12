using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    public class empty
    {
        public int randomNumber { get; set; }
        public AnEmptyFunction AnEmpty { get; }

        public empty(AnEmptyFunction anEmpty)
        {
            AnEmpty = anEmpty;
        }
    }

    public class AnEmptyFunction
    { }
}
