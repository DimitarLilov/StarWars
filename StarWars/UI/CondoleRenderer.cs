using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.UI
{
    public class CondoleRenderer
    {
        public void WriteLine(string message, params object[] param)
        {
            Console.WriteLine(message, param);
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
